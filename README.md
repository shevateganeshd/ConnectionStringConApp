**CONNECTION STRING**

**PARAMETERS AND ITS USE**

1. Data Source/Server=DESKTOP-S87FPOF\SQLEXPRESS,1433; | MSSQL/MySQL/PostreSQL Server Name,PortNo

2. Initial Catalog=CRM; | Database Name

3. UID=sa; | Username OR UserId

4. Password=ABC@; | Password

5. Integrated Security=True; | True if using Windows Authentication (no User Id or Password required). Set to False if using SQL Authentication

6. Trusted_Connection=True; | Enabling Windows Authentication

7. Connection Timeout=30; | Seconds application will wait to establish a connection before throwing an error

8. Encrypt = True; | Secure the connection with encryption

9. TrustServerCertificate=True; | When connecting via SSL but the server's certificate can't be validated

10. Persist Security Info = True; | Want to retain sensitive connection details (e.g. password) after the connection is opened. Typically set to False for security

11. Application Name=MyApplication; | Identify the application in database logs for tracking and monitoring

12. MultipleActiveResultSets=True; | When needed multiple queries to execute on the same connection simultaneously (e.g. fetching and updating data in parallel)

13. Pooling = True; | Enable connection pooling, which improves performance by reusing existing connections

14. Max Pool Size=100; | Maximum number of connections allowed in the connection pool

15. Min Pool Size=10; | Minimum number of connections allowed in the connection pool

16. Provider = System.Data.SqlClient; | Specify the database provider (e.g. System.Data.SqlClient for SQL Server)

17. Charset = utf8; | Specifies character encoding (e.g. utf8)

18. SSL Mode = Require; | Defines SSL behavior (e.g. Require)
