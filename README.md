# AngularTestAutomationCakeScript
Angular 7 Application Test Automation using cake script

#Web Page
Create Angular Application
  > npm install
  > npm install -g @angular/cli
  > ng generate component calculator
  > ng serve
  
Update App.module.ts for new Component
Browse http://localhost:4200/calculator/

#Test Prject
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

#Generate trx file
 Open VS2017 Command Prompt in solution folder
  > vstest.console.exe AutomationTest\bin\Debug\AutomationTest.dll /logger:"trx"

# Live Documentation using Pickle
