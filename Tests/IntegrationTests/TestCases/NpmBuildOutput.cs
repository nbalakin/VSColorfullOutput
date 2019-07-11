using System;
using System.Diagnostics.CodeAnalysis;

namespace Balakin.VSOutputEnhancer.Tests.IntegrationTests.TestCases
{
    [ExcludeFromCodeCoverage]
    public class NpmBuildOutput : NpmOutputBase
    {
        public override String ContentType { get; } = VSOutputEnhancer.ContentType.BuildOutput;
    }
}