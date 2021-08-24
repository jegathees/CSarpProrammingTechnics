# CSarpProgrammingTechnics

Asynchronous Programming

In computer programming, the async/await pattern is a syntactic feature of many programming languages that allows an asynchronous, non-blocking function to be structured in a way similar to an ordinary synchronous function. It is semantically related to the concept of a coroutine and is often implemented using similar techniques, and is primarily intended to provide opportunities for the program to execute other code while waiting for a long-running, asynchronous task to complete, usually represented by promises or similar data structures

By using asynchronous programming, we avoid performance bottlenecks and enhance the responsiveness of our applications. It is a programming technique that allows us to execute our flows without blocking our application or causing the thread pool starvation. 

The often misconception is that by using the async and await keywords we gain better performance in terms of the speed of our application. But that’s not the case. For example, if we have synchronous code that fetches the data from the database and it takes three seconds to complete, our asynchronous code won’t be any faster than that. But we do get an indirect performance improvement regarding how many concurrent requests our server can handle. In other words, we increase the scalability of our application by using the async and await keywords. 
