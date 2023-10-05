# Hacker News Api

This api project fetch the top 200 news from the hacker api and serve the angular code.
Api url is : https://rsystemshackernewsapi.azurewebsites.net/api

## Table of Contents

- [Introduction]  
- [Getting Started](#getting-started)
  - [Prerequisites](#prerequisites)
- [Usage](#usage)
- [Configuration](#configuration)
- [Testing](#testing)
- [Contributing](#contributing)
- [License](#license)
- [Acknowledgements](#acknowledgements)

## Introduction

This api project fetch the top 200 news from the hacker api and serve the angular code.
Api solution is created in .Net core. It consists of 4 libraries:RSystemsHackerNews.API, RSystemsHackerNews.Business, RSystemsHackerNews.Data, RSystemsHackerNews.Tests

## Getting Started

Download the project from git hub by using https://sahilhackernewsapp.azurewebsites.net/. Just rebuild the solution after open that in Visual studio.

### Prerequisites

Visual Studio 2022

## Usage

After configuring the project from git. 
Open project the visual studio 2022 and rebuild the solution.
Make sure RSystemsHackerNews.API- should be the startup project. 
After successfull building click on run.
It will open swagger UI just expand the list of apis and try the NewStories api.
It will return the list of records.

## Configuration

Url of the hacker api is provided in the appsettings.json file of RSystemsHackerNews.API.
In IntegrationTests file of RSystemsHackerNews.Tests project azure api url is passed for integratin testing.
If you want to test that on local just change that url with url that is getting after running the api project.

## Testing

 ### Unit testing
nUnit, Moq are used for test cases.
3 unit test cases are there in the RSystemsHackerNews.Tests project and StoriesControllerTest file.
Just Run the test case, test cases are using Mock data from MockData file. 

 ###Integration testing

1 integration test case is there that calls the https://rsystemshackernewsapi.azurewebsites.net/api/Stories/NewStories api deployed on azure to get the data.
This test case include the testing of controller method, Services method along with caching.
To test this on local we need to change the url in the IntegrationTests file of RSystemsHackerNews.Tests.


