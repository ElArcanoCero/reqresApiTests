using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.ApplicationInsights.MetricDimensionNames.TelemetryContext;

namespace reqresApiTests.Models;

internal class UserResponse
{
    public required User Data { get; set; }
}