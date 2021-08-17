Utah Camping Availability Finder 1.1

**OBJECTIVES**
- Learn how to use Selenium
- refresh OOP skills
- refresh C# skills
- create a functionable availibility finder for personal use

Description - a simple console application that checks for any availability across all campgrounds for
a desried date range. Additional features such as generating a listing of availible sites and site amenities
may be added in future versions.

**DESIGN**

*Classes*
>Campground< 
- int numAvailable

> Availability (this will be included in future versions)<
- string campgroundName
- string siteNum
- bool electricHookup
- int nightlyRate
etc.

*Output to console will be of form...*

"There are ___ reservable sites and ___ first-come-first-serve sites available for your selected date(s) within a 200 mile radius of ____"

CAMPGROUND NAME     TOTAL # OF SITES     # OF RESERVABLE SITES     # OF FIRST-COME-FIRST-SERVE
Mirror Lake				79						10							50
-
-


TO DO...
- error checking on input date
- format output

Next Time:
- finish watching video (below)
- navigate to each of the campground sites in turn by either storing their URLs in a collection or navigating with the Chrome driver
- scrape the collection of campsite information for each campground, then parse needed information afterwards



WORK LOG

- 8/2/2021  3 hrs
	- Start project, formulate plan and create README. Research Selenium
- 8/3/2021  2 hrs
	- Practice using Selenium
- 8/5/2021  3 hrs
	- Code foundation for project MVC
- 8/17/2021  2.5 hrs
	- research about Web scraping, minor changes
	- https://www.youtube.com/watch?v=gRoMR3NcpPQ  helpful video about webscraping collections


Resources
- https://www.youtube.com/watch?v=gRoMR3NcpPQ Webscraping collections

