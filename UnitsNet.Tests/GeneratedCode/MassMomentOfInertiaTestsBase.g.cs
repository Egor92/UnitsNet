﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by \generate-code.bat.
//
//     Changes to this file will be lost when the code is regenerated.
//     The build server regenerates the code before each build and a pre-build
//     step will regenerate the code on each local build.
//
//     See https://github.com/anjdreas/UnitsNet/wiki/Adding-a-New-Unit for how to add or edit units.
//
//     Add CustomCode\UnitClasses\MyUnit.extra.cs files to add code to generated unit classes.
//     Add Extensions\MyUnitExtensions.cs to decorate unit classes with new behavior.
//     Add UnitDefinitions\MyUnit.json and run GeneratUnits.bat to generate new units or unit classes.
//
// </auto-generated>
//------------------------------------------------------------------------------

// Copyright (c) 2007 Andreas Gullberg Larsen (anjdreas@gmail.com).
// https://github.com/anjdreas/UnitsNet
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using System;
using UnitsNet.Units;
using Xunit;

// Disable build warning CS1718: Comparison made to same variable; did you mean to compare something else?
#pragma warning disable 1718

// ReSharper disable once CheckNamespace
namespace UnitsNet.Tests
{
    /// <summary>
    /// Test of MassMomentOfInertia.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class MassMomentOfInertiaTestsBase
    {
        protected abstract double GramSquareCentimetersInOneKilogramSquareMeter { get; }
        protected abstract double GramSquareDecimetersInOneKilogramSquareMeter { get; }
        protected abstract double GramSquareMetersInOneKilogramSquareMeter { get; }
        protected abstract double GramSquareMillimetersInOneKilogramSquareMeter { get; }
        protected abstract double KilogramSquareCentimetersInOneKilogramSquareMeter { get; }
        protected abstract double KilogramSquareDecimetersInOneKilogramSquareMeter { get; }
        protected abstract double KilogramSquareMetersInOneKilogramSquareMeter { get; }
        protected abstract double KilogramSquareMillimetersInOneKilogramSquareMeter { get; }
        protected abstract double MilligramSquareCentimetersInOneKilogramSquareMeter { get; }
        protected abstract double MilligramSquareDecimetersInOneKilogramSquareMeter { get; }
        protected abstract double MilligramSquareMetersInOneKilogramSquareMeter { get; }
        protected abstract double MilligramSquareMillimetersInOneKilogramSquareMeter { get; }
        protected abstract double PoundSquareFeetInOneKilogramSquareMeter { get; }
        protected abstract double PoundSquareInchesInOneKilogramSquareMeter { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double GramSquareCentimetersTolerance { get { return 1e-5; } }
        protected virtual double GramSquareDecimetersTolerance { get { return 1e-5; } }
        protected virtual double GramSquareMetersTolerance { get { return 1e-5; } }
        protected virtual double GramSquareMillimetersTolerance { get { return 1e-5; } }
        protected virtual double KilogramSquareCentimetersTolerance { get { return 1e-5; } }
        protected virtual double KilogramSquareDecimetersTolerance { get { return 1e-5; } }
        protected virtual double KilogramSquareMetersTolerance { get { return 1e-5; } }
        protected virtual double KilogramSquareMillimetersTolerance { get { return 1e-5; } }
        protected virtual double MilligramSquareCentimetersTolerance { get { return 1e-5; } }
        protected virtual double MilligramSquareDecimetersTolerance { get { return 1e-5; } }
        protected virtual double MilligramSquareMetersTolerance { get { return 1e-5; } }
        protected virtual double MilligramSquareMillimetersTolerance { get { return 1e-5; } }
        protected virtual double PoundSquareFeetTolerance { get { return 1e-5; } }
        protected virtual double PoundSquareInchesTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        [Fact]
        public void KilogramSquareMeterToMassMomentOfInertiaUnits()
        {
            MassMomentOfInertia kilogramsquaremeter = MassMomentOfInertia.FromKilogramSquareMeters(1);
            AssertEx.EqualTolerance(GramSquareCentimetersInOneKilogramSquareMeter, kilogramsquaremeter.GramSquareCentimeters, GramSquareCentimetersTolerance);
            AssertEx.EqualTolerance(GramSquareDecimetersInOneKilogramSquareMeter, kilogramsquaremeter.GramSquareDecimeters, GramSquareDecimetersTolerance);
            AssertEx.EqualTolerance(GramSquareMetersInOneKilogramSquareMeter, kilogramsquaremeter.GramSquareMeters, GramSquareMetersTolerance);
            AssertEx.EqualTolerance(GramSquareMillimetersInOneKilogramSquareMeter, kilogramsquaremeter.GramSquareMillimeters, GramSquareMillimetersTolerance);
            AssertEx.EqualTolerance(KilogramSquareCentimetersInOneKilogramSquareMeter, kilogramsquaremeter.KilogramSquareCentimeters, KilogramSquareCentimetersTolerance);
            AssertEx.EqualTolerance(KilogramSquareDecimetersInOneKilogramSquareMeter, kilogramsquaremeter.KilogramSquareDecimeters, KilogramSquareDecimetersTolerance);
            AssertEx.EqualTolerance(KilogramSquareMetersInOneKilogramSquareMeter, kilogramsquaremeter.KilogramSquareMeters, KilogramSquareMetersTolerance);
            AssertEx.EqualTolerance(KilogramSquareMillimetersInOneKilogramSquareMeter, kilogramsquaremeter.KilogramSquareMillimeters, KilogramSquareMillimetersTolerance);
            AssertEx.EqualTolerance(MilligramSquareCentimetersInOneKilogramSquareMeter, kilogramsquaremeter.MilligramSquareCentimeters, MilligramSquareCentimetersTolerance);
            AssertEx.EqualTolerance(MilligramSquareDecimetersInOneKilogramSquareMeter, kilogramsquaremeter.MilligramSquareDecimeters, MilligramSquareDecimetersTolerance);
            AssertEx.EqualTolerance(MilligramSquareMetersInOneKilogramSquareMeter, kilogramsquaremeter.MilligramSquareMeters, MilligramSquareMetersTolerance);
            AssertEx.EqualTolerance(MilligramSquareMillimetersInOneKilogramSquareMeter, kilogramsquaremeter.MilligramSquareMillimeters, MilligramSquareMillimetersTolerance);
            AssertEx.EqualTolerance(PoundSquareFeetInOneKilogramSquareMeter, kilogramsquaremeter.PoundSquareFeet, PoundSquareFeetTolerance);
            AssertEx.EqualTolerance(PoundSquareInchesInOneKilogramSquareMeter, kilogramsquaremeter.PoundSquareInches, PoundSquareInchesTolerance);
        }

        [Fact]
        public void FromValueAndUnit()
        {
            AssertEx.EqualTolerance(1, MassMomentOfInertia.From(1, MassMomentOfInertiaUnit.GramSquareCentimeter).GramSquareCentimeters, GramSquareCentimetersTolerance);
            AssertEx.EqualTolerance(1, MassMomentOfInertia.From(1, MassMomentOfInertiaUnit.GramSquareDecimeter).GramSquareDecimeters, GramSquareDecimetersTolerance);
            AssertEx.EqualTolerance(1, MassMomentOfInertia.From(1, MassMomentOfInertiaUnit.GramSquareMeter).GramSquareMeters, GramSquareMetersTolerance);
            AssertEx.EqualTolerance(1, MassMomentOfInertia.From(1, MassMomentOfInertiaUnit.GramSquareMillimeter).GramSquareMillimeters, GramSquareMillimetersTolerance);
            AssertEx.EqualTolerance(1, MassMomentOfInertia.From(1, MassMomentOfInertiaUnit.KilogramSquareCentimeter).KilogramSquareCentimeters, KilogramSquareCentimetersTolerance);
            AssertEx.EqualTolerance(1, MassMomentOfInertia.From(1, MassMomentOfInertiaUnit.KilogramSquareDecimeter).KilogramSquareDecimeters, KilogramSquareDecimetersTolerance);
            AssertEx.EqualTolerance(1, MassMomentOfInertia.From(1, MassMomentOfInertiaUnit.KilogramSquareMeter).KilogramSquareMeters, KilogramSquareMetersTolerance);
            AssertEx.EqualTolerance(1, MassMomentOfInertia.From(1, MassMomentOfInertiaUnit.KilogramSquareMillimeter).KilogramSquareMillimeters, KilogramSquareMillimetersTolerance);
            AssertEx.EqualTolerance(1, MassMomentOfInertia.From(1, MassMomentOfInertiaUnit.MilligramSquareCentimeter).MilligramSquareCentimeters, MilligramSquareCentimetersTolerance);
            AssertEx.EqualTolerance(1, MassMomentOfInertia.From(1, MassMomentOfInertiaUnit.MilligramSquareDecimeter).MilligramSquareDecimeters, MilligramSquareDecimetersTolerance);
            AssertEx.EqualTolerance(1, MassMomentOfInertia.From(1, MassMomentOfInertiaUnit.MilligramSquareMeter).MilligramSquareMeters, MilligramSquareMetersTolerance);
            AssertEx.EqualTolerance(1, MassMomentOfInertia.From(1, MassMomentOfInertiaUnit.MilligramSquareMillimeter).MilligramSquareMillimeters, MilligramSquareMillimetersTolerance);
            AssertEx.EqualTolerance(1, MassMomentOfInertia.From(1, MassMomentOfInertiaUnit.PoundSquareFoot).PoundSquareFeet, PoundSquareFeetTolerance);
            AssertEx.EqualTolerance(1, MassMomentOfInertia.From(1, MassMomentOfInertiaUnit.PoundSquareInch).PoundSquareInches, PoundSquareInchesTolerance);
        }

        [Fact]
        public void As()
        {
            var kilogramsquaremeter = MassMomentOfInertia.FromKilogramSquareMeters(1);
            AssertEx.EqualTolerance(GramSquareCentimetersInOneKilogramSquareMeter, kilogramsquaremeter.As(MassMomentOfInertiaUnit.GramSquareCentimeter), GramSquareCentimetersTolerance);
            AssertEx.EqualTolerance(GramSquareDecimetersInOneKilogramSquareMeter, kilogramsquaremeter.As(MassMomentOfInertiaUnit.GramSquareDecimeter), GramSquareDecimetersTolerance);
            AssertEx.EqualTolerance(GramSquareMetersInOneKilogramSquareMeter, kilogramsquaremeter.As(MassMomentOfInertiaUnit.GramSquareMeter), GramSquareMetersTolerance);
            AssertEx.EqualTolerance(GramSquareMillimetersInOneKilogramSquareMeter, kilogramsquaremeter.As(MassMomentOfInertiaUnit.GramSquareMillimeter), GramSquareMillimetersTolerance);
            AssertEx.EqualTolerance(KilogramSquareCentimetersInOneKilogramSquareMeter, kilogramsquaremeter.As(MassMomentOfInertiaUnit.KilogramSquareCentimeter), KilogramSquareCentimetersTolerance);
            AssertEx.EqualTolerance(KilogramSquareDecimetersInOneKilogramSquareMeter, kilogramsquaremeter.As(MassMomentOfInertiaUnit.KilogramSquareDecimeter), KilogramSquareDecimetersTolerance);
            AssertEx.EqualTolerance(KilogramSquareMetersInOneKilogramSquareMeter, kilogramsquaremeter.As(MassMomentOfInertiaUnit.KilogramSquareMeter), KilogramSquareMetersTolerance);
            AssertEx.EqualTolerance(KilogramSquareMillimetersInOneKilogramSquareMeter, kilogramsquaremeter.As(MassMomentOfInertiaUnit.KilogramSquareMillimeter), KilogramSquareMillimetersTolerance);
            AssertEx.EqualTolerance(MilligramSquareCentimetersInOneKilogramSquareMeter, kilogramsquaremeter.As(MassMomentOfInertiaUnit.MilligramSquareCentimeter), MilligramSquareCentimetersTolerance);
            AssertEx.EqualTolerance(MilligramSquareDecimetersInOneKilogramSquareMeter, kilogramsquaremeter.As(MassMomentOfInertiaUnit.MilligramSquareDecimeter), MilligramSquareDecimetersTolerance);
            AssertEx.EqualTolerance(MilligramSquareMetersInOneKilogramSquareMeter, kilogramsquaremeter.As(MassMomentOfInertiaUnit.MilligramSquareMeter), MilligramSquareMetersTolerance);
            AssertEx.EqualTolerance(MilligramSquareMillimetersInOneKilogramSquareMeter, kilogramsquaremeter.As(MassMomentOfInertiaUnit.MilligramSquareMillimeter), MilligramSquareMillimetersTolerance);
            AssertEx.EqualTolerance(PoundSquareFeetInOneKilogramSquareMeter, kilogramsquaremeter.As(MassMomentOfInertiaUnit.PoundSquareFoot), PoundSquareFeetTolerance);
            AssertEx.EqualTolerance(PoundSquareInchesInOneKilogramSquareMeter, kilogramsquaremeter.As(MassMomentOfInertiaUnit.PoundSquareInch), PoundSquareInchesTolerance);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            MassMomentOfInertia kilogramsquaremeter = MassMomentOfInertia.FromKilogramSquareMeters(1);
            AssertEx.EqualTolerance(1, MassMomentOfInertia.FromGramSquareCentimeters(kilogramsquaremeter.GramSquareCentimeters).KilogramSquareMeters, GramSquareCentimetersTolerance);
            AssertEx.EqualTolerance(1, MassMomentOfInertia.FromGramSquareDecimeters(kilogramsquaremeter.GramSquareDecimeters).KilogramSquareMeters, GramSquareDecimetersTolerance);
            AssertEx.EqualTolerance(1, MassMomentOfInertia.FromGramSquareMeters(kilogramsquaremeter.GramSquareMeters).KilogramSquareMeters, GramSquareMetersTolerance);
            AssertEx.EqualTolerance(1, MassMomentOfInertia.FromGramSquareMillimeters(kilogramsquaremeter.GramSquareMillimeters).KilogramSquareMeters, GramSquareMillimetersTolerance);
            AssertEx.EqualTolerance(1, MassMomentOfInertia.FromKilogramSquareCentimeters(kilogramsquaremeter.KilogramSquareCentimeters).KilogramSquareMeters, KilogramSquareCentimetersTolerance);
            AssertEx.EqualTolerance(1, MassMomentOfInertia.FromKilogramSquareDecimeters(kilogramsquaremeter.KilogramSquareDecimeters).KilogramSquareMeters, KilogramSquareDecimetersTolerance);
            AssertEx.EqualTolerance(1, MassMomentOfInertia.FromKilogramSquareMeters(kilogramsquaremeter.KilogramSquareMeters).KilogramSquareMeters, KilogramSquareMetersTolerance);
            AssertEx.EqualTolerance(1, MassMomentOfInertia.FromKilogramSquareMillimeters(kilogramsquaremeter.KilogramSquareMillimeters).KilogramSquareMeters, KilogramSquareMillimetersTolerance);
            AssertEx.EqualTolerance(1, MassMomentOfInertia.FromMilligramSquareCentimeters(kilogramsquaremeter.MilligramSquareCentimeters).KilogramSquareMeters, MilligramSquareCentimetersTolerance);
            AssertEx.EqualTolerance(1, MassMomentOfInertia.FromMilligramSquareDecimeters(kilogramsquaremeter.MilligramSquareDecimeters).KilogramSquareMeters, MilligramSquareDecimetersTolerance);
            AssertEx.EqualTolerance(1, MassMomentOfInertia.FromMilligramSquareMeters(kilogramsquaremeter.MilligramSquareMeters).KilogramSquareMeters, MilligramSquareMetersTolerance);
            AssertEx.EqualTolerance(1, MassMomentOfInertia.FromMilligramSquareMillimeters(kilogramsquaremeter.MilligramSquareMillimeters).KilogramSquareMeters, MilligramSquareMillimetersTolerance);
            AssertEx.EqualTolerance(1, MassMomentOfInertia.FromPoundSquareFeet(kilogramsquaremeter.PoundSquareFeet).KilogramSquareMeters, PoundSquareFeetTolerance);
            AssertEx.EqualTolerance(1, MassMomentOfInertia.FromPoundSquareInches(kilogramsquaremeter.PoundSquareInches).KilogramSquareMeters, PoundSquareInchesTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            MassMomentOfInertia v = MassMomentOfInertia.FromKilogramSquareMeters(1);
            AssertEx.EqualTolerance(-1, -v.KilogramSquareMeters, KilogramSquareMetersTolerance);
            AssertEx.EqualTolerance(2, (MassMomentOfInertia.FromKilogramSquareMeters(3)-v).KilogramSquareMeters, KilogramSquareMetersTolerance);
            AssertEx.EqualTolerance(2, (v + v).KilogramSquareMeters, KilogramSquareMetersTolerance);
            AssertEx.EqualTolerance(10, (v*10).KilogramSquareMeters, KilogramSquareMetersTolerance);
            AssertEx.EqualTolerance(10, (10*v).KilogramSquareMeters, KilogramSquareMetersTolerance);
            AssertEx.EqualTolerance(2, (MassMomentOfInertia.FromKilogramSquareMeters(10)/5).KilogramSquareMeters, KilogramSquareMetersTolerance);
            AssertEx.EqualTolerance(2, MassMomentOfInertia.FromKilogramSquareMeters(10)/MassMomentOfInertia.FromKilogramSquareMeters(5), KilogramSquareMetersTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            MassMomentOfInertia oneKilogramSquareMeter = MassMomentOfInertia.FromKilogramSquareMeters(1);
            MassMomentOfInertia twoKilogramSquareMeters = MassMomentOfInertia.FromKilogramSquareMeters(2);

            Assert.True(oneKilogramSquareMeter < twoKilogramSquareMeters);
            Assert.True(oneKilogramSquareMeter <= twoKilogramSquareMeters);
            Assert.True(twoKilogramSquareMeters > oneKilogramSquareMeter);
            Assert.True(twoKilogramSquareMeters >= oneKilogramSquareMeter);

            Assert.False(oneKilogramSquareMeter > twoKilogramSquareMeters);
            Assert.False(oneKilogramSquareMeter >= twoKilogramSquareMeters);
            Assert.False(twoKilogramSquareMeters < oneKilogramSquareMeter);
            Assert.False(twoKilogramSquareMeters <= oneKilogramSquareMeter);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            MassMomentOfInertia kilogramsquaremeter = MassMomentOfInertia.FromKilogramSquareMeters(1);
            Assert.Equal(0, kilogramsquaremeter.CompareTo(kilogramsquaremeter));
            Assert.True(kilogramsquaremeter.CompareTo(MassMomentOfInertia.Zero) > 0);
            Assert.True(MassMomentOfInertia.Zero.CompareTo(kilogramsquaremeter) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            MassMomentOfInertia kilogramsquaremeter = MassMomentOfInertia.FromKilogramSquareMeters(1);
            Assert.Throws<ArgumentException>(() => kilogramsquaremeter.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            MassMomentOfInertia kilogramsquaremeter = MassMomentOfInertia.FromKilogramSquareMeters(1);
            Assert.Throws<ArgumentNullException>(() => kilogramsquaremeter.CompareTo(null));
        }


        [Fact]
        public void EqualityOperators()
        {
            MassMomentOfInertia a = MassMomentOfInertia.FromKilogramSquareMeters(1);
            MassMomentOfInertia b = MassMomentOfInertia.FromKilogramSquareMeters(2);

// ReSharper disable EqualExpressionComparison
            Assert.True(a == a);
            Assert.True(a != b);

            Assert.False(a == b);
            Assert.False(a != a);
// ReSharper restore EqualExpressionComparison
        }

        [Fact]
        public void EqualsIsImplemented()
        {
            MassMomentOfInertia v = MassMomentOfInertia.FromKilogramSquareMeters(1);
            Assert.True(v.Equals(MassMomentOfInertia.FromKilogramSquareMeters(1)));
            Assert.False(v.Equals(MassMomentOfInertia.Zero));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            MassMomentOfInertia kilogramsquaremeter = MassMomentOfInertia.FromKilogramSquareMeters(1);
            Assert.False(kilogramsquaremeter.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            MassMomentOfInertia kilogramsquaremeter = MassMomentOfInertia.FromKilogramSquareMeters(1);
            Assert.False(kilogramsquaremeter.Equals(null));
        }
    }
}
