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

namespace com.clover.sdk.v3.base_ {


public class ServiceCharge {

  /// <summary>
  /// Unique identifier
  /// </summary>
  public String id { get; set; }

  /// <summary>
  /// The order with which the service charge is associated
  /// </summary>
  public com.clover.sdk.v3.base_.Reference orderRef { get; set; }

  /// <summary>
  /// Service charge name
  /// </summary>
  public String name { get; set; }

  /// <summary>
  /// If this service charge is enabled
  /// </summary>
  public Boolean enabled { get; set; }

  /// <summary>
  /// DEPRECATED
  /// </summary>
  public Int64 percentage { get; set; }

  /// <summary>
  /// Percent to charge times 10000, e.g. 12.5% will be 125000
  /// </summary>
  public Int64 percentageDecimal { get; set; }

}

}