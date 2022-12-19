# ef_join_aggregation
A prototype to model aggregations and joins in EF. As a service part, it consists of the 'EndOfWeek()' function.

1. Create and init the database
```
PS> cd script
PS> .\drop-database.ps1
...
PS> cd script
PS> .\init-database.ps1
```

2. Run the API

There are two possible run configurations: __Timesheets__ and __Tickets__.

3. Access the URL

Get grouping:

- http://localhost:5000/timesheet?startDate=2022-02-01&endDate=2022-04-30
- https://localhost:5001/timesheet?startDate=2022-02-01&endDate=2022-04-30

Get an end date of the week:

- https://localhost:5001/timesheet/endOfWeek?dt=2022-03-13&startOfWeek=Saturday
- https://localhost:5001/timesheet/endOfWeek?dt=2022-03-16&startOfWeek=Saturday
- https://localhost:5001/timesheet/endOfWeek?dt=2022-03-12&startOfWeek=Saturday
- https://localhost:5001/timesheet/endOfWeek?dt=2022-03-11&startOfWeek=Saturday

Get SLA cache aggregation (spent/left):
- https://localhost:5001/ticket?referenceTime=2022-12-11T09:30:00