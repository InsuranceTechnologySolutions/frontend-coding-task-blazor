# Frontend Coding Task

## Read this first!
This repository is a template repository for our technical interview, so create your own project using this guide:

[GitHub - Creating a repository from a template](https://docs.github.com/en/repositories/creating-and-managing-repositories/creating-a-repository-from-a-template).

An alternative is to download the code and create a new repository using a different VCS provider (gitlab / Azure repos). **Do not fork this repository.**

When you have completed the tasks, please share the repository link with us. We will review your submission before the interview.

## Backstory
One common problem in shipping is to fill an anchorage efficiently with as many vessels as possible. You will create a **Single Page Application** to manually solve this problem (*). The vessels should be placed in the anchorage using **drag and drop**. You will have access to an API which tells you what size the bin is (anchorage) and what items (vessels) to fill in. 

## Prerequisites

- Your favourite IDE to code C# / Blazor 😀
    - .net 10 SDK installed
- github account, we want you to publish your code to a public repository which you share with us. 

## The Task

In the `AnchorageFiller` directory of this repository, we have provided a basic Blazor App you can extend to solve this task.
The AnchorageFiller solution consists of the following projects:
* `AnchorageFiller.Clients` - Strongly typed client that can be used to fetch a response from our API.
* `AnchorageFiller.Server` - AspNetCore server used to host the WebAssembly app and to proxy requests to our API.
* `AnchorageFiller.Web` - Blazor WebAssembly app.

### Suggested UI:

<img src="images/Wireframes_3.png" alt="Wireframes" width="600" />

The API response states that there are 2 vessels with size (6x5) and 5 vessels with size (3X12). These can be dragged (and dropped) into the anchorage area. 

<img src="images/Wireframes_1.png" alt="Wireframes" width="600" />

4 vessels have been placed into the anchorage, 0 (6x5) vessels and 3 (3x12) vessels remaining. 

<img src="images/Wireframes_2.png" alt="Wireframes" width="600" />

You are done. 🥳 Clicking the "Try again!" button issues a new request to the API. Based on the response, render a new anchorage and the vessels / items to fill it with. 

### Additional information:
- It could be that the vessels must be possible to rotate 90 degrees to utilize all space in the anchorage. You decide how to do this from a UX perspective. If this is not possible, leave it.
- Overlap between vessels is not possible 💥 
- Our API does not guarantee anchorages that can be filled. There may be too many vessels in the response. Then you need to provide means to try again, perhaps always show that button? 
- The state of the anchorage does not have to be persisted, page reload will be a new try. 
- Any security concerns are out of scope (auth ++). 
- You can use third party libraries / components. 

## What will we evaluate?
- Apart from a functional SPA, we want you create a codebase which is "clean" (adhere to the SOLID principles). 
- We value clean code, accessibility, project structure and usability over having lots of functionality. Consider this if you have limited time.
- Are there any parts which can be unit tested? 
- How do you do state management?
- Apply CSS/Bootstraping to make the SPA look a bit nicer than the wireframes.
- Documentation - either in code or in a separate readme is highly appreciated.
- We do not like AI/Agent generated readme files. They tend to be bloated, we would much rather read documentation where the content is created by you 🫵 (do not stress with spelling mistakes too much, they just make the content look genuine).

Good luck! 🙂  If you have any questions, do not hesitate to contact us.


<small>(*) Fun fact: This is called the binpack problem [Wikipedia](https://en.wikipedia.org/wiki/Bin_packing_problem). </small>

