#r "System.Xml.Linq.dll"
#r "packages/FSharp.Data.2.0.4/lib/net40/FSharp.Data.dll"
open FSharp.Data

// ------------------------------------------------------------------
// WORD #1
//
// Use the WorldBank type provider to get all countries in the 
// "North America" region, then find country "c" with the smallest
// "Life expectancy at birth, total (years)" value in the year 2000
// and return the first two letters of the "c.Code" property
// ------------------------------------------------------------------

// Create connection to the WorldBank service
let wb = WorldBankData.GetDataContext()
// Get specific indicator for a specific country at a given year
wb.Countries.``Czech Republic``.Indicators.``Population, total``.[2000]
// Get a list of countries in a specified region
wb.Regions.``Euro area``.Countries


// ------------------------------------------------------------------
// WORD #2
//
// Read the RSS feed in "data/bbc.xml" using XmlProvider and return
// the last word of the title of an article that was published at
// 9:05am (the date does not matter, just hours & minutes)
// ------------------------------------------------------------------

// Create a type for working with XML documents based on a sample file
type Sample = XmlProvider<"data/Writers.xml">
// Load the sample document - explore properties using "doc."
let doc = Sample.GetSample()

