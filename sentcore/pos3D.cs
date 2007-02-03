/*
    Sentience 3D Perception System
    Copyright (C) 2000-2007 Bob Mottram
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
    public class pos3Dbase
    {
        public float x, y, z;

        public pos3Dbase(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
    }


    public class pos3D : pos3Dbase
    {
        public float pan, tilt, roll;

        public float new_pan_angle, dist_xy;

        public pos3D(float x, float y, float z) : base(x,y,z)
        {
        }

        public pos3D add(pos3D other)
        {
            pos3D sum = new pos3D(x, y, z);
            sum.x = x + other.x;
            sum.y = y + other.y;
            sum.z = z + other.z;
            sum.pan = pan + other.pan;
            sum.tilt = tilt + other.tilt;
            sum.roll = roll + other.roll;
            return (sum);
        }

        public pos3D subtract(pos3D other)
        {
            pos3D sum = new pos3D(x, y, z);
            sum.x = x - other.x;
            sum.y = y - other.y;
            sum.z = z - other.z;
            sum.pan = pan - other.pan;
            sum.tilt = tilt - other.tilt;
            sum.roll = roll - other.roll;
            return (sum);
        }

        public pos3D rotate(float pan, float tilt, float roll)
        {
            float hyp;
            pos3D rotated = new pos3D(x,y,z);

            // roll            
            //if (roll != 0)
            {
                hyp = (float)Math.Sqrt((rotated.x * rotated.x) + (rotated.z * rotated.z));
                if (hyp > 0)
                {
                    float roll_angle = (float)Math.Acos(rotated.z / hyp);
                    if (rotated.x < 0) roll_angle = (float)(Math.PI * 2) - roll_angle;
                    float new_roll_angle = roll + roll_angle;
                    rotated.x = hyp * (float)Math.Sin(new_roll_angle);
                    rotated.z = hyp * (float)Math.Cos(new_roll_angle);
                }
            }
            if (tilt != 0)
            {
                // tilt
                hyp = (float)Math.Sqrt((rotated.y * rotated.y) + (rotated.z * rotated.z));
                if (hyp > 0)
                {
                    float tilt_angle = (float)Math.Acos(rotated.y / hyp);
                    if (rotated.z < 0) tilt_angle = (float)(Math.PI * 2) - tilt_angle;
                    float new_tilt_angle = tilt + tilt_angle;
                    rotated.y = hyp * (float)Math.Sin(new_tilt_angle);
                    rotated.z = hyp * (float)Math.Cos(new_tilt_angle);
                }
            }

            
            
            //if (pan != 0)
            {
                // pan                
                hyp = (float)Math.Sqrt((rotated.x * rotated.x) + (rotated.y * rotated.y));
                if (hyp > 0)
                {
                    float pan_angle = (float)Math.Acos(rotated.y / hyp);
                    if (rotated.x < 0) pan_angle = (float)(Math.PI * 2) - pan_angle;
                    rotated.new_pan_angle = pan - pan_angle;
                    rotated.dist_xy = hyp;
                    rotated.x = hyp * (float)Math.Sin(rotated.new_pan_angle);
                    rotated.y = hyp * (float)Math.Cos(rotated.new_pan_angle);
                }
            }
            rotated.pan = this.pan + pan;
            rotated.tilt = this.tilt + tilt;
            rotated.roll = this.roll + roll;
            return (rotated);
        }

        /// <summary>
        /// return a translated version of the point
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="z"></param>
        /// <returns></returns>
        public pos3D translate(float x, float y, float z)
        {
            return(new pos3D(this.x + x, this.y + y, this.z + z));
        }
    }
}