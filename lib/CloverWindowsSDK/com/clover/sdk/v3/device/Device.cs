/**
 * Autogenerated by Avro
 * 
 * DO NOT EDIT DIRECTLY
 */

// Copyright (C) 2016 Clover Network, Inc.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
//
// You may obtain a copy of the License at
//    http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using System;
using System.Collections.Generic;

namespace com.clover.sdk.v3.device {


public class Device {

  /// <summary>
  /// Unique identifier
  /// </summary>
  public String id { get; set; }

  /// <summary>
  /// Name of the device (if entered)
  /// </summary>
  public String name { get; set; }

  public String model { get; set; }

  public String orderPrefix { get; set; }

  public Int32 terminalPrefix { get; set; }

  public String serial { get; set; }

  public Int64 buildNumber { get; set; }

  public String secureId { get; set; }

  public com.clover.sdk.v3.device.BuildType buildType { get; set; }

  public String cpuId { get; set; }

  /// <summary>
  /// The IMEI of the device
  /// </summary>
  public String imei { get; set; }

  /// <summary>
  /// The IMSI of the SIM in the device (if present)
  /// </summary>
  public String imsi { get; set; }

  /// <summary>
  /// The ICCID of the SIM in the device (if present)
  /// </summary>
  public String simIccid { get; set; }

  public String deviceCertificate { get; set; }

  public String pedCertificate { get; set; }

  public String deviceTypeName { get; set; }

  public Boolean pinDisabled { get; set; }

  public Boolean offlinePayments { get; set; }

  public Boolean offlinePaymentsAll { get; set; }

  public Int64 offlinePaymentsLimit { get; set; }

  public Int64 offlinePaymentsPromptThreshold { get; set; }

  public List<com.clover.sdk.v3.base_.Reference> secureReports { get; set; }

}

}
