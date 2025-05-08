
I welcome anyone who wants to contribute, either by writing a Clogger or contributing to the core. I am well aware that this is not anything groundbreaking, but a nice place to practice, learn, or just come up with ideas to make things better.

***Please have fun and be your best self....cheesy yet true.***


**Purpose:** To provide an easily extendable API for logging events
It should be relatively easy to add new event types and new loggers
It needs to have the inner workings hidden but an open interface for extension

**Food for thought**
 - TODO: Incorporate attribute(s) into CLogger instead of passing it around
 - TODO: Handle 2 new EventTypes 	None: turn of logging on thais Clogger 	All: turn on logging for all events
 - Add a dictionary to store all registered loggers
 - Allow for removal of loggers
 - Config File?
 - configurable output formatting

a logger is 1 single logger with all of the events they register for.
Loggers are a collection of loggers that are registered for 1+ events

Logging should be done with a single call: logger.log(message)
a log should be able to register for multiple events
A log should be able to be added or removed by the end user making a call
A log should be able to unregistered from any event the end user wants.
A user should be able to see the list of Events/logs that are active at any time
