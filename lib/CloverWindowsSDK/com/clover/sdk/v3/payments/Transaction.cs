/**
 * Autogenerated by Avro
 * 
 * DO NOT EDIT DIRECTLY
 */

// Copyright (C) 2018 Clover Network, Inc.
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

namespace com.clover.sdk.v3.payments {


public class Transaction {

  /// <summary>
  /// The time when the transaction was recorded on the server
  /// </summary>
  public Int64 createdTime { get; set; }

  /// <summary>
  /// The time when the transaction was recorded on the client
  /// </summary>
  public Int64 clientCreatedTime { get; set; }

  public com.clover.sdk.v3.payments.Payment payment { get; set; }

  public com.clover.sdk.v3.payments.Refund refund { get; set; }

  public com.clover.sdk.v3.payments.Credit credit { get; set; }

}

}
