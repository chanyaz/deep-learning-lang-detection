﻿module MovieNews.Data.NewYorkTimes

open System
open FSharp.Data


type NYT = JsonProvider<"http://api.nytimes.com/svc/movies/v2/reviews/search.json?api-key=973b7af4093746e7928878c20023ece3">

let baseUrl = "http://api.nytimes.com/svc/movies/v2/reviews/search.json"
let apiKey = "973b7af4093746e7928878c20023ece3"

let tryPickReviewByName name response = 
    let nyt = NYT.Parse(response)
    nyt.Results 
    |> Seq.tryFind (fun r -> String.Equals(r.DisplayTitle , name, StringComparison.OrdinalIgnoreCase)) 
    |> Option.map (fun r -> 
        {   Published = r.PublicationDate 
            Summary = r.SummaryShort
            Link = r.Link.Url
            LinkText = r.Link.SuggestedLinkText })

let throttler = Utils.createThrottler 200

let tryDownloadReviewByName name =
    async{
        let query = ["api-key",apiKey; "query" , name]
        let! response = throttler baseUrl query
        return tryPickReviewByName name response
    }