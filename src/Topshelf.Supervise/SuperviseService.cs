﻿// Copyright 2007-2012 Chris Patterson, Dru Sellers, Travis Smith, et. al.
//  
// Licensed under the Apache License, Version 2.0 (the "License"); you may not use 
// this file except in compliance with the License. You may obtain a copy of the 
// License at 
// 
//     http://www.apache.org/licenses/LICENSE-2.0 
// 
// Unless required by applicable law or agreed to in writing, software distributed 
// under the License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR 
// CONDITIONS OF ANY KIND, either express or implied. See the License for the 
// specific language governing permissions and limitations under the License.
namespace Topshelf.Supervise
{
    using HostConfigurators;
    using Runtime;

    public class SuperviseService :
        ServiceControl
    {
        readonly ServiceBuilderFactory _serviceBuilderFactory;
        readonly HostSettings _settings;
        readonly ServiceAvailability _serviceAvailability;
        SuperviseHost _host;

        public SuperviseService(HostSettings settings, ServiceAvailability serviceAvailability, ServiceBuilderFactory serviceBuilderFactory)
        {
            _settings = settings;
            _serviceAvailability = serviceAvailability;
            _serviceBuilderFactory = serviceBuilderFactory;
        }

        public bool Start(HostControl hostControl)
        {
            _host = new SuperviseHost(hostControl, _settings, _serviceBuilderFactory);

            if(_serviceAvailability.CanStart())
                _host.Start();

            return true;
        }

        public bool Stop(HostControl hostControl)
        {
            _host.Stop();

            return true;
        }
    }
}