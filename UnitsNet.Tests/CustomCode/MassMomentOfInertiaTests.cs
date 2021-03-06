﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated (once) by \generate-code.bat, but will not be
//     regenerated when it already exists. The purpose of creating this file is to make 
//     it easier to remember to implement all the unit conversion test cases.
// 
//     Whenever a new unit is added to this unit class and \generate-code.bat is run,
//     the base test class will get a new abstract property and cause a compile error
//     in this derived class, reminding the developer to implement the test case
//     for the new unit.
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

namespace UnitsNet.Tests.CustomCode
{
    public class MassMomentOfInertiaTests : MassMomentOfInertiaTestsBase
    {
        protected override double GramSquareCentimetersInOneKilogramSquareMeter => 1e7;

        protected override double GramSquareDecimetersInOneKilogramSquareMeter => 1e5;

        protected override double GramSquareMetersInOneKilogramSquareMeter => 1e3;

        protected override double GramSquareMillimetersInOneKilogramSquareMeter => 1e9;

        protected override double KilogramSquareCentimetersInOneKilogramSquareMeter => 1e4;

        protected override double KilogramSquareDecimetersInOneKilogramSquareMeter => 1e2;

        protected override double KilogramSquareMetersInOneKilogramSquareMeter => 1;

        protected override double KilogramSquareMillimetersInOneKilogramSquareMeter => 1e6;

        protected override double MilligramSquareCentimetersInOneKilogramSquareMeter => 1e10;

        protected override double MilligramSquareDecimetersInOneKilogramSquareMeter => 1e8;

        protected override double MilligramSquareMetersInOneKilogramSquareMeter => 1e6;

        protected override double MilligramSquareMillimetersInOneKilogramSquareMeter => 1e12;

        protected override double PoundSquareFeetInOneKilogramSquareMeter => 1 / 4.21401101e-2;

        protected override double PoundSquareInchesInOneKilogramSquareMeter => 1 / 2.9263965e-4;
    }
}
