using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.ApplicationInsights.MetricDimensionNames.TelemetryContext;

namespace reqresApiTests.Models;

public class UserResponse
{
    public User Data { get; set; } = new();
}