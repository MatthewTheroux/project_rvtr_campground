## [0]. ABOUT
# project_clerktracker



## [I].  USE CASES
##  00.  an Administrator; i.e., "us," should be able to 

- launch the application
- add the (initial) Head CSM
- debug code, when needed
- update code, when needed

##   [ADVANCED] 02
##    02.  a CampgroundOwner should be able to 

- look up who is currently staying
- look up who is coming and when
- look up who is leaving and when


##   03.  a CampsiteRenter should be able to 

- launch the application
- add other CSMs
- add other Clerks
- pair other Clerks' devices

- (Daily)
- add or update the daily clerk plan, (see diagram)
- track clerks' positions, scheduled tasks, reported tasks, break times
- send a clerk a direct message
  - e.g., "Please report to the Customer Service Desk."

- send *all* clerks an APB message
  - e.g., "<!> Spill in Aisle __." [advanced: "Code 3: Liquid."]
  - e.g., "<!> Change bottle bins." 
  - e.g., "<!> Run Garbage."
  - A Clerk can respond with the "I got it." button.

##   04.  a (Courtesy) Clerk should be able to 
- pair personal device with the desk's.

- (Daily)
- launch the application.
- view scheduled tasks for the day.
- receive a notification on the next scheduled task.
- confirm a scheduled task is being attended.
- notify (to the CSM) a change in current task work.
  - e.g., 

  

## [II].  Architecture (using C# / .NET)

+ [solution] Campgrounds.sln

  + [project - ?mvc] Campgrounds.Client.csproj

  + [project - classlib] Campgrounds.Domain.csproj
    + [folder] Abstracts
    + [folder] Interfaces, (if needed)
    + [folder] Models

  + [project - classlib ] Campgrounds.Storage.csproj
    + [file] CampgroundsContext.cs
    + [folder] Repositories
      + [file] CSMRepository
      + [file] ClerkRepository


  + [project - xunit] Campgrounds.Testing.csproj
    + [folder] Tests
      + [folder] UnitTests
\




## [III].  Requirements

The application is centered around the interaction of X main objects:
- Campground
- CampgroundOwner
- CampgroundTransaction

- Campsite
- CampsiteRenter
- CampsiteTennant
- CampsiteBill


## [IV].  Timelines

- Sprint #1 will run 
    from 2021 June 02 at 06:00 EDT, 05:00 CDT 
    to 2021 June 09 at 06:00 EDT, 05:00 CDT

- Sprint #2 will run 
    from 2021 June 02 at 06:00 EDT, 05:00 CDT 
    to 2021 June 09 at 06:00 EDT, 05:00 CDT


## [V]. Minimum Viable Product
- as an mvp (minimum viable product) status, the application should be able to
  
- book a campsite
- 



- have at least have 10 each validation unit tests for Customer, Order, Pizza, Store.

> The goal is to try to complete as many reqs as you can in the time alloted. :)
'Gook Luch, 
--"Mad Matt."
