# AngularTestAutomationCakeScript
Angular 7 Application Test Automation using cake script

# Web Page
Create Angular Application
  > npm install
  > npm install -g @angular/cli
  > ng generate component calculator
  > ng serve
  
Update App.module.ts for new Component
Browse http://localhost:4200/calculator/

# Test Prject
Selenium  Using .Net Framework, VS2017
 New .Net Framework Unit Test Project, Add Nuget packages- 
  MSTest.TestAdapter
  MSTest.TestFramework
  Protractor
  Selenium.Chrome.WebDriver
  Selenium.WebDriver
  Shouldly
  SpecFlow
  SpecFlow.MsTest
  SpecFlow.Tools.MsBuild.Generation

Add Feature file, Write Scenario > Right Click > Generate Step Defination > Update step files and Run

# Generate trx file using vstest
# Note- MSTest V2 not work with MSTest command  
 Open VS2017 Command Prompt in solution folder
  > vstest.console.exe AutomationTest\bin\Debug\AutomationTest.dll /logger:"trx"

# Live Documentation using Pickle
 UI - https://chocolatey.org/packages/picklesui
    - Download
    - run exe
    - Fill input
    - generate and check output directory
    - Can generate CLI command from UI
 
 Command - 
  https://chocolatey.org/packages/pickles
  
  Run cmd to pickles.exe path 
  
  C:\Tools\pickles.2.20.1\tools>pickles.exe --feature-directory="C:\Project\TestAutomation\Test\AutomationTest\AutomationTest\Features" --output-directory="C:\Project\TestAutomation\Test\AutomationTest\Docs\DHtml" --system-under-test-name=C:\Project\TestAutomation\Test\AutomationTest\AutomationTest\AutomationTest.csproj --system-under-test-version=1.0 --link-results-file="C:\Project\TestAutomation\Test\AutomationTest\TestResults\OWQ8_IN01LAP81064_2019-01-14_18_41_02.trx" --test-results-format=vstest --documentation-format=dhtml
