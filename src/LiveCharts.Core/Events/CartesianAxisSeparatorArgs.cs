﻿#region License
// The MIT License (MIT)
// 
// Copyright (c) 2016 Alberto Rodríguez Orozco & LiveCharts contributors
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy 
// of this software and associated documentation files (the "Software"), to deal 
// in the Software without restriction, including without limitation the rights to 
// use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies 
// of the Software, and to permit persons to whom the Software is furnished to 
// do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all 
// copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, 
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES 
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND 
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT 
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, 
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING 
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR 
// OTHER DEALINGS IN THE SOFTWARE.
#endregion

#region

using System.Drawing;
using LiveCharts.Core.Abstractions;
using LiveCharts.Core.Dimensions;
using LiveCharts.Core.Drawing;

#endregion

namespace LiveCharts.Core.Events
{
    /// <summary>
    /// The Cartesian Axis Separator Arguments.
    /// </summary>
    public class CartesianAxisSeparatorArgs
    {
        /// <summary>
        /// Gets or sets from.
        /// </summary>
        /// <value>
        /// From.
        /// </value>
        public RectangleF SeparatorFrom { get; internal set; }

        /// <summary>
        /// Gets or sets to.
        /// </summary>
        /// <value>
        /// To.
        /// </value>
        public RectangleF SeparatorTo { get; internal set; }

        /// <summary>
        /// Gets the label from.
        /// </summary>
        /// <value>
        /// The label from.
        /// </value>
        public PointF LabelFrom { get; internal set; }

        /// <summary>
        /// Gets or sets the axis label model.
        /// </summary>
        /// <value>
        /// The axis label model.
        /// </value>
        public AxisLabelViewModel LabelViewModel { get; internal set; }

        /// <summary>
        /// Gets the plane.
        /// </summary>
        /// <value>
        /// The plane.
        /// </value>
        public Plane Plane { get; internal set; }

        /// <summary>
        /// Gets a value indicating whether this <see cref="CartesianAxisSeparatorArgs"/> is disposing.
        /// </summary>
        /// <value>
        ///   <c>true</c> if disposing; otherwise, <c>false</c>.
        /// </value>
        public bool Disposing { get; internal set; }

        /// <summary>
        /// Gets the plane.
        /// </summary>
        /// <value>
        /// The plane.
        /// </value>
        public SeparatorStyle Style { get; internal set; }

        /// <summary>
        /// Gets the chart view.
        /// </summary>
        /// <value>
        /// The chart view.
        /// </value>
        public IChartView ChartView { get; internal set; }
    }
}