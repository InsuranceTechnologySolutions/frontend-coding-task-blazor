# Frontend Coding Task


## Backstory
One common problem in shipping is to fill an anchorage efficiently with as many vessels as possible. You will create a Single Page Application to manually solve this ("binpack" problem [Wikipedia](https://en.wikipedia.org/wiki/Bin_packing_problem)). You will have access to an API which tells you what size the bin is (anchorage) and what items (vessels) to fill in it. 

## Prerequisites

- Your favourite IDE to code C# / Blazor
    - .net 9 SDK installed

## The Task

Create a Blazor WASM or Server app which connects to the api at URL: [https://esa.instech.no/](https://esa.instech.no/).

A request like this:
```sh
$ curl -X GET https://esa.instech.no/api/fleets/random
```
.. can produce a JSON response with data similar to this:
```json
{
  "anchorageSize": {
    "width": 12,
    "height": 15
  },
  "fleets": [
    {
      "singleShipDimensions": { "width": 6, "height": 5 },
      "shipDesignation": "LNG Unit",
      "shipCount": 2
    },
    {
      "singleShipDimensions": { "width": 3, "height": 12 },
      "shipDesignation": "Science & Engineering Ship",
      "shipCount": 5
    }
  ]
}
```

### Suggested UI:

Wireframe 1:
![Wireframes](images/Wireframes_3.png)

The json states that there are 2 vessels with size (6x5) and 5 vessels with size (3X12). These can be dragged (and dropped) into the anchorage area. 

Wireframe 2:
![Wireframes](images/Wireframes_1.png)

4 vessels have been placed into the anchorage, 0 (6x5) vessels and 3 (3x12) vessels remaining. 

Wireframe 3:
![Wireframes](images/Wireframes_2.png)

You are done. 🥳 Clicking the "Try again!" button issues a new request to the API. Based on the response, render a new anchorage and the vessels / items to fill it with. 

## What will we evaluate?
Apart from a functional SPA, we want you create a codebase which is "clean" (adhere to the SOLID principles). Are there any parts which can be unit tested? We are quite cuirous when it comes to how you solve state management. 




