﻿//
//  Copyright 2012  Xamarin Inc.
//
//    Licensed under the Apache License, Version 2.0 (the "License");
//    you may not use this file except in compliance with the License.
//    You may obtain a copy of the License at
//
//        http://www.apache.org/licenses/LICENSE-2.0
//
//    Unless required by applicable law or agreed to in writing, software
//    distributed under the License is distributed on an "AS IS" BASIS,
//    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//    See the License for the specific language governing permissions and
//    limitations under the License.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RemittanceAdvice {

	/// <summary>
	/// Interface providing backend data to ViewModels
	/// </summary>
	public interface ILoginService {

		/// <summary>
		/// Asynchronous login
		/// </summary>
		Task<bool> LoginAsync (string username, string password, CancellationToken cancellationToken = default(CancellationToken));
	}
}
