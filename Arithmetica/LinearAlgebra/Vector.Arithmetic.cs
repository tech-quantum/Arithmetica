﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using NumSharp;

namespace Arithmetica.LinearAlgebra
{
    public partial class Vector<T>
    {
        /// <summary>
        /// Performs the dot product between 2 Vector<T>.
        /// </summary>
        /// <param name="lhs">The first Vector<T>.</param>
        /// <param name="rhs">The second Vector<T>.</param>
        /// <returns></returns>
        public static Vector<T> CrossProduct(Vector<T> lhs, Vector<T> rhs) => Global.OP.Dot(lhs.variable, rhs.variable.transpose());

        /// <summary>
        /// Performs elementwise add operation between two Vector<T>
        /// </summary>
        /// <param name="lhs">The first Vector<T>.</param>
        /// <param name="rhs">The second Vector<T>.</param>
        /// <returns></returns>
        public static Vector<T> Add(Vector<T> lhs, Vector<T> rhs) => np.add(lhs.variable, rhs.variable);

        /// <summary>
        /// Performs elementwise add operation between Vector<T> and scalar
        /// </summary>
        /// <param name="lhs">The first Vector<T>.</param>
        /// <param name="rhs">The scalar value.</param>
        /// <returns></returns>
        public static Vector<T> Add(Vector<T> lhs, float rhs) => np.add(lhs.variable, rhs);

        /// <summary>
        /// Performs elementwise add operation between scalar and Vector<T>
        /// </summary>
        /// <param name="lhs">The first Vector<T>.</param>
        /// <param name="rhs">The scalar value.</param>
        /// <returns></returns>
        public static Vector<T> Add(float lhs, Vector<T> rhs) => np.add(rhs.variable, lhs);

        /// <summary>
        /// Performs elementwise subtract operation between two Vector<T>
        /// </summary>
        /// <param name="lhs">The first Vector<T>.</param>
        /// <param name="rhs">The second Vector<T>.</param>
        /// <returns></returns>
        public static Vector<T> Sub(Vector<T> lhs, Vector<T> rhs) => np.subtract(lhs.variable, rhs.variable);

        /// <summary>
        /// Performs elementwise subtract operation between scalar and Vector<T>
        /// </summary>
        /// <param name="lhs">The first Vector<T>.</param>
        /// <param name="rhs">The scalar value.</param>
        /// <returns></returns>
        public static Vector<T> Sub(Vector<T> lhs, float rhs) => np.subtract(lhs.variable, rhs);

        /// <summary>
        /// Performs elementwise multiplication operation between two Vector<T>
        /// </summary>
        /// <param name="lhs">The first Vector<T>.</param>
        /// <param name="rhs">The second Vector<T>.</param>
        /// <returns></returns>
        public static Vector<T> Sub(float lhs, Vector<T> rhs) => np.subtract(lhs, rhs.variable);

        /// <summary>
        /// Performs elementwise multiplication operation between Vector<T> and scalar
        /// </summary>
        /// <param name="lhs">The first Vector<T>.</param>
        /// <param name="rhs">The scalar value.</param>
        /// <returns></returns>
        public static Vector<T> Mul(Vector<T> lhs, Vector<T> rhs) => np.multiply(lhs.variable, rhs.variable);

        /// <summary>
        /// Performs elementwise multiplication operation between Vector<T> and scalar
        /// </summary>
        /// <param name="lhs">The first Vector<T>.</param>
        /// <param name="rhs">The scalar value.</param>
        /// <returns></returns>
        public static Vector<T> Mul(Vector<T> lhs, float rhs) => np.multiply(lhs.variable, rhs);

        /// <summary>
        /// Performs elementwise multiplication operation between scalar and Vector<T>
        /// </summary>
        /// <param name="lhs">The first Vector<T>.</param>
        /// <param name="rhs">The scalar value.</param>
        /// <returns></returns>
        public static Vector<T> Mul(float lhs, Vector<T> rhs) => np.multiply(rhs.variable, lhs);

        /// <summary>
        /// Performs elementwise divide operation between two Vector<T>
        /// </summary>
        /// <param name="lhs">The first Vector<T>.</param>
        /// <param name="rhs">The second Vector<T>.</param>
        /// <returns></returns>
        public static Vector<T> Div(Vector<T> lhs, Vector<T> rhs) => np.divide(lhs.variable, rhs.variable);

        /// <summary>
        /// Performs elementwise divide operation between Vector<T> and scalar
        /// </summary>
        /// <param name="lhs">The first Vector<T>.</param>
        /// <param name="rhs">The scalar value.</param>
        /// <returns></returns>
        public static Vector<T> Div(Vector<T> lhs, float rhs) => np.divide(lhs.variable, rhs);

        /// <summary>
        /// Performs elementwise divide operation between scalar and Vector<T>
        /// </summary>
        /// <param name="lhs">The first Vector<T>.</param>
        /// <param name="rhs">The scalar value.</param>
        /// <returns></returns>
        public static Vector<T> Div(float lhs, Vector<T> rhs) => np.divide(lhs, rhs.variable);

        /// <summary>
        /// Performs elementwise divide modulus for the first Vector<T> against a scalar value
        /// </summary>
        /// <param name="lhs">The first Vector<T>.</param>
        /// <param name="rhs">The scalar value.</param>
        /// <returns></returns>
        public static Vector<T> Mod(Vector<T> lhs, float rhs) => np.mod(lhs.variable, rhs);

        /// <summary>
        /// Negates the specified Vector<T>.
        /// </summary>
        /// <param name="src">The source Vector<T>.</param>
        /// <returns></returns>
        public static Vector<T> Neg(Vector<T> src) => np.negative(src.variable);

        /// <summary>
        /// Finds the elementwise absolute value of the Vector<T>
        /// </summary>
        /// <param name="src">The source Vector<T>.</param>
        /// <returns></returns>
        public static Vector<T> Abs(Vector<T> src) => np.abs(src.variable);

        /// <summary>
        /// Returns an element-wise indication of the sign of a number. The sign function returns -1 if x< 0, 0 if x==0, 1 if x> 0. nan is returned for nan inputs.
        /// For complex inputs, the sign function returns sign(x.real) + 0j if x.real != 0 else sign(x.imag) + 0j.
        /// </summary>
        /// <param name="src">The source Vector<T>.</param>
        /// <returns></returns>
        public static Vector<T> Sign(Vector<T> src) => np.sign(src.variable);

        /// <summary>
        /// Finds the linear interpolation is a method of curve fitting using linear polynomials to construct new data points within the range of a discrete set of known data points.
        /// </summary>
        /// <param name="a">The first Vector<T></param>
        /// <param name="b">The second Vector<T>.</param>
        /// <param name="weight">The weight.</param>
        /// <returns></returns>
        public static Vector<T> Lerp(Vector<T> a, Vector<T> b, float weight) => Global.OP.Lerp(a.variable, b.variable, weight);
    }
}
