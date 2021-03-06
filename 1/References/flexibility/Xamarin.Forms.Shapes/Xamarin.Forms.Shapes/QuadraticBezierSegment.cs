﻿namespace Xamarin.Forms.Media
{
    public sealed class QuadraticBezierSegment : PathSegment
    {
        public static readonly BindableProperty Point1Property =
            BindableProperty.Create("Point1",
                                    typeof(Point),
                                    typeof(QuadraticBezierSegment),
                                    new Point(0, 0));

        public static readonly BindableProperty Point2Property =
            BindableProperty.Create("Point2",
                                    typeof(Point),
                                    typeof(QuadraticBezierSegment),
                                    new Point(0, 0));

        public Point Point1
        {
            set { SetValue(Point1Property, value); }
            get { return (Point)GetValue(Point1Property); }
        }

        public Point Point2
        {
            set { SetValue(Point2Property, value); }
            get { return (Point)GetValue(Point2Property); }
        }
    }
}

