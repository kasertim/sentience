/*
    FAST line detector
    Copyright (C) 2006 Bob Mottram
    fuzzgun@gmail.com

    This program is free software; you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation; either version 2 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License along
    with this program; if not, write to the Free Software Foundation, Inc.,
    51 Franklin Street, Fifth Floor, Boston, MA 02110-1301 USA.
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace sentience.core
{
    public class FASTlines
    {
        public bool showGravity = false;
        public bool showHorizon = false;
        public int required_lines = 100;

        public FASTline[] lines;

        int required_features = 200;
        int horizon_threshold = 10;

        int corner_threshold = 0;
        int line_threshold = 0;

        //output image
        public Byte[] output_image = null;
        Byte[] mono_image;

        public void Update(Byte[] raw_image, int width, int height)
        {
            mono_image = util.monoImage(raw_image, width, height);

            if (line_threshold == 0) line_threshold = 200;
            if (corner_threshold == 0) corner_threshold = 50;
            FASTcorner[] corners_all = FAST.fast_corner_detect_10(mono_image, width, height, corner_threshold);
            FASTcorner[] corners = FAST.fast_nonmax(mono_image, width, height, corners_all, corner_threshold * 2, 0, 0);

            if (corners != null)
            {
                int no_of_feats = corners.Length;
                if (no_of_feats < required_features / 2) corner_threshold -= 4;
                if (no_of_feats > required_features) corner_threshold += 4;

                if ((no_of_feats > 1) && (no_of_feats < required_features * 2))
                {
                    int min_line_length = width / 10;
                    lines = FAST.fast_lines(mono_image, width, height, corners, line_threshold, min_line_length);

                    if (lines != null)
                    {
                        int no_of_lines = 0;
                        for (int i = 0; i < lines.Length; i++)
                        {
                            FASTline line = lines[i];
                            if (!(((line.point1.y < height / 10) && (line.point2.y < height / 10)) ||
                                  ((line.point1.y > height - (height / 20)) && (line.point2.y > height - (height / 20))) ||
                                  ((line.point1.x > width - (width / 20)) && (line.point2.x > width - (width / 20))) ||
                                  ((line.point1.x < width / 20) && (line.point2.x < width / 20))
                                  ))
                            {
                                line.Visible = true;
                                no_of_lines++;
                            }
                        }


                        // detect the horizon
                        if (showHorizon)
                        {
                            int vertical_position = 0;
                            float gradient = FAST.horizon_detection(raw_image, width, height, lines, horizon_threshold, ref vertical_position);

                            if (vertical_position > 0)
                            {
                                int tx = (width / 2) + (int)((width / 4) * 1);
                                int ty = vertical_position - (int)((width / 4) * gradient);
                                //ty = ty * height / width;
                                util.drawLine(raw_image, width, height, width / 2, vertical_position, tx, ty, 0, 255, 0, 1, false);
                            }
                        }

                        // draw lines

                        for (int i = 0; i < lines.Length; i++)
                        {
                            FASTline line = lines[i];
                            if (line.Visible)
                            {
                                if (!line.onHorizon)
                                {
                                    util.drawLine(raw_image, width, height,
                                                  line.point1.x, line.point1.y, line.point2.x, line.point2.y,
                                                  255, 0, 0, 0, false);
                                }
                                else
                                {
                                    util.drawLine(raw_image, width, height,
                                                  line.point1.x, line.point1.y, line.point2.x, line.point2.y,
                                                  0, 255, 0, 0, false);
                                }
                            }
                        }


                        if (no_of_lines < required_lines)
                            line_threshold -= 4;
                        if (no_of_lines > required_lines)
                            line_threshold += 8;
                        if (line_threshold < 130) line_threshold = 130;


                        // detect the gravity angle
                        if (showGravity)
                        {
                            float gravity_angle = FAST.gravity_direction(lines);
                            int pendulum_length = width / 8;
                            int px = (width / 2) + (int)(pendulum_length * Math.Sin(gravity_angle));
                            int py = (height / 2) + (int)(pendulum_length * Math.Cos(gravity_angle) * height / width);
                            util.drawLine(raw_image, width, height,
                                          width / 2, height / 2, px, py,
                                          0, 255, 0, 1, false);

                            int arrow_length = pendulum_length / 5;
                            float angle2 = gravity_angle + (float)(Math.PI * 0.8f);
                            int px2 = px + (int)(arrow_length * Math.Sin(angle2));
                            int py2 = py + (int)(arrow_length * Math.Cos(angle2) * height / width);
                            util.drawLine(raw_image, width, height,
                                          px2, py2, px, py,
                                          0, 255, 0, 1, false);

                            angle2 = gravity_angle - (float)(Math.PI * 0.8f);
                            px2 = px + (int)(arrow_length * Math.Sin(angle2));
                            py2 = py + (int)(arrow_length * Math.Cos(angle2) * height / width);
                            util.drawLine(raw_image, width, height,
                                          px2, py2, px, py,
                                          0, 255, 0, 1, false);
                        }
                    }
                }
            }

            //odometry.update(disp_bmp_data, width, height);
            output_image = raw_image;
        }

    }
}
