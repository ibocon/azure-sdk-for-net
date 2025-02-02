// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Net.Http;
using Azure.Core.Pipeline;
using Azure.Core.TestFramework;

namespace Azure.Analytics.Purview.Scanning.Tests
{
    public class ScanningServiceClientTestBase : RecordedTestBase<PurviewScanningTestEnvironment>
    {
        public ScanningServiceClientTestBase(bool isAsync) : base(isAsync)
        {
        }

        public ScanningServiceClientTestBase(bool isAsync, RecordedTestMode mode) : base(isAsync, mode)
        {
        }

        public PurviewScanningServiceClient GetScanningClient()
        {
            var httpHandler = new HttpClientHandler();
            httpHandler.ServerCertificateCustomValidationCallback = (_, _, _, _) =>
            {
                return true;
            };
            var options = new PurviewScanningServiceClientOptions { Transport = new HttpClientTransport(httpHandler) };
            return InstrumentClient(new PurviewScanningServiceClient(TestEnvironment.Endpoint, TestEnvironment.Credential, InstrumentClientOptions(options)));
        }
    }
}
