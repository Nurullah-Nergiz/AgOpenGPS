﻿using OpenTK.Graphics.OpenGL;
using System;
using System.Collections.Generic;

namespace AgOpenGPS
{
    public partial class CBoundary
    {
        //copy of the mainform address
        private readonly FormGPS mf;

        public List<CBoundaryList> bndList = new List<CBoundaryList>();

        //constructor
        public CBoundary(FormGPS _f)
        {
            mf = _f;
            fenceSelected = 0;
            boxLength = 2000;
            turnSelected = 0;
            isHeadlandOn = false;
            isToolUp = true;
        }
    }
}