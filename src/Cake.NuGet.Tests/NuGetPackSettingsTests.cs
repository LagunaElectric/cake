﻿using Xunit;

namespace Cake.NuGet.Tests
{
    public sealed class NuGetPackSettingsTests
    {
        public sealed class TheConstructor
        {
            [Fact]
            public void Should_Set_NoPackageAnalysis_To_False_By_Default()
            {
                // Given, When
                var settings = new NuGetPackSettings();

                // Then
                Assert.False(settings.NoPackageAnalysis);
            }
        }
    }
}
