using System;
using DotNetCoreKoans.Engine;

namespace DotNetCoreKoans.Koans
{
    public class PathToEnlightenment : Path
    {
        public PathToEnlightenment()
        {
             Types = new Type[] {
                // typeof(AboutAsserts),
                typeof(AboutNull),
                typeof(AboutArrays),
                // typeof(AboutArrayAssignment),
                // typeof(AboutStrings),
                // typeof(AboutFloats),
                // typeof(AboutInheritance),
                typeof(AboutMethods),
                // typeof(AboutControlStatements),
                // typeof(AboutGenericContainers),
                // typeof(AboutLambdas),
                // typeof(AboutLinq),
                // typeof(AboutDelegates),
                // typeof(AboutBitwiseAndShiftOperator),
                };
        }
    }
}