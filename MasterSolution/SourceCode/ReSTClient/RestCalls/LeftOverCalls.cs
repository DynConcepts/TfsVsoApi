using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynCon.OSI.VSO.ReSTClient.RestCalls
{
    class LeftOverCalls
    {
        /*
_apis/clt/apm/applications		GET		https://fabrikam.vsclt.visualstudio.com/_apis/clt/apm/applications?pluginType=ApplicationInsights
_apis/clt/apm/counters		GET		https://fabrikam.vsclt.visualstudio.com/_apis/clt/apm/counters?pluginType=ApplicationInsights&applicationId=myfirstapp
_apis/clt/apm/plugins		GET		https://fabrikam.vsclt.visualstudio.com/_apis/clt/apm/plugins
_apis/clt/apm/plugins/{type}		GET		https://fabrikam.vsclt.visualstudio.com/_apis/clt/apm/plugins/applicationinsights
_apis/clt/testRuns/{testrunId}/CounterInstances		GET		https://fabrikam.vsclt.visualstudio.com/_apis/clt/testRuns/5c9dc626-44aa-410b-8f75-2929dd330397/CounterInstances?groupNames=Performance%2CThroughput%2CApplication
https://{account}.vsclt.visualstudio.com/_apis/clt/testRuns/{testrunId}/CounterSamples		POST		https://fabrikam.vsclt.visualstudio.com/_apis/clt/testRuns/28fec23a-91f9-4983-8bc6-1d58cc1b79f1/CounterSamples
/_apis/clt/testRuns/{testRunID}/Errors		GET		https://fabrikam.vsclt.visualstudio.com/_apis/clt/testRuns/47be20f0-ac4a-40cd-acb7-d9f8c44d0404/Errors
/_apis/clt/testRuns/47be20f0-ac4a-40cd-acb7-d9f8c44d0404/Messages		GET		https://fabrikam.vsclt.visualstudio.com/_apis/clt/testRuns/47be20f0-ac4a-40cd-acb7-d9f8c44d0404/Messages
/TestService/TestDrop/{api-version}/{testDropId}		DELETE		https://af6f3429f-8f33-414e-af7a-79ec4c98ab3c.vsclt.visualstudio.com/testservice/testdrop/1.3/f2f44a65-c94b-450a-83ab-ac2303555135/
/TestService/TestDrop/{api-version}/GetTestDrops		GET		https://af6f3429f-8f33-414e-af7a-79ec4c98ab3c.vsclt.visualstudio.com/TestService/TestDrop/1.3/GetTestDrops
/_apis/clt/TestDrops		GET		https://fabrikam.vsclt.visualstudio.com/_apis/clt/TestDrops/f2f44a65-c94b-450a-83ab-ac2303555135
/_apis/clt/TestDrops		POST		https://fabrikam.vsclt.visualstudio.com/_apis/clt/TestDrops
/_apis/clt/TestRuns/{testRunId}/results		GET		https://fabrikam.vsclt.visualstudio.com/_apis/clt/TestRuns/2150fbd4-e71c-42fd-8b90-95222a556d87/results
/TestService/TestResult/{api-version}/{testRunId}/samples		GET		https://af6f3429f-8f33-414e-af7a-79ec4c98ab3c.vsclt.visualstudio.com/testservice/testresult/1.3/854a7b79-efd3-4e48-b6b2-6b99b1adc731/samples?counterIds=-2020039322,-1543222480,-1854500553,-1828439162&fromMarker=9&tillMarker=509
/TestService/TestResult/{api-version}/{testRunId}/testMessageCount		GET		https://af6f3429f-8f33-414e-af7a-79ec4c98ab3c.vsclt.visualstudio.com/testservice/testresult/1.3/854a7b79-efd3-4e48-b6b2-6b99b1adc731/testmessagecount?keylist=Status%20messages,All%20test%20errors
/TestService/TestService/{api-version}/{testRunId}		DELETE		https://af6f3429f-8f33-414e-af7a-79ec4c98ab3c.vsclt.visualstudio.com/testservice/testservice/1.3/854a7b79-efd3-4e48-b6b2-6b99b1adc731/
_apis/clt/TestRuns		GET		https://fabrikam.vsclt.visualstudio.com/_apis/clt/TestRuns
/_apis/clt/TestRuns		GET		https://fabrikam.vsclt.visualstudio.com/_apis/clt/TestRuns?fromDate=20140623T061334Z&toDate=20140623T061422Z
/_apis/clt/TestRuns/{testRunId}		GET		https://fabrikam.vsclt.visualstudio.com/_apis/clt/TestRuns/854a7b79-efd3-4e48-b6b2-6b99b1adc731
/_apis/clt/testruns/{testRunId}		PATCH		https://fabrikam.vsclt.visualstudio.com/_apis/clt/testruns/854a7b79-efd3-4e48-b6b2-6b99b1adc731
/_apis/clt/TestRuns/		POST		https://fabrikam.vsclt.visualstudio.com/_apis/clt/TestRuns
/Accounts		GET		https://app.vssps.visualstudio.com/_apis/Accounts?memberId=d6245f20-2af8-44f4-9451-8107cb2767db&api-version=1.0
/profile/profiles/me		GET		https://app.vssps.visualstudio.com/_apis/profile/profiles/me?api-version=1.0
/profile/profiles/me/avatar		GET		https://app.vssps.visualstudio.com/_apis/profile/profiles/me/avatar?api-version=1.0
/test/{projectName}/plans/{planId}/suites/{suiteId}/testcases		GET		fabrikam-fiber-tfvc/_apis/test/plans/1/suites/1/testcases?api-version=1.0

         */
    }
}
