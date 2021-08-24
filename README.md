# CSarpProgrammingTechnics

Asynchronous Programming

In computer programming, the async/await pattern is a syntactic feature of many programming languages that allows an asynchronous, non-blocking function to be structured in a way similar to an ordinary synchronous function. It is semantically related to the concept of a coroutine and is often implemented using similar techniques, and is primarily intended to provide opportunities for the program to execute other code while waiting for a long-running, asynchronous task to complete, usually represented by promises or similar data structures

By using asynchronous programming, we avoid performance bottlenecks and enhance the responsiveness of our applications. It is a programming technique that allows us to execute our flows without blocking our application or causing the thread pool starvation. 

The often misconception is that by using the async and await keywords we gain better performance in terms of the speed of our application. But that’s not the case. For example, if we have synchronous code that fetches the data from the database and it takes three seconds to complete, our asynchronous code won’t be any faster than that. But we do get an indirect performance improvement regarding how many concurrent requests our server can handle. In other words, we increase the scalability of our application by using the async and await keywords. 

So, let’s talk a bit about scaling and learn why is it so important.

When we deploy our API to the server, that server can handle only a certain amount of requests. If our API receives more requests than our server can handle, the overall performance of our application will suffer. So, what we can do is to add an additional server to handle those additional requests, and we call it horizontal scaling. The other thing we can do is to improve the allocated resources on that single server by increasing the memory or CPU power, and we call this vertical scaling. So in other words, if we create an application in such a way that the resource utilization is improved, we improve the scalability of our application. That’s exactly why async code is important. By its proper usage, we can increase the vertical scalability at the server level of our API.
