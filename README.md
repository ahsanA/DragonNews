# DragonNews
Assignment For Crossover Tech Trial

- Steps To Create and Initialize Database:
-------------------------------------------

    1. Create a database called 'DragonNews'
    2. Run the script located on the following Direction:
    ahsan_ahmad-CSharpAssignment.zip\Source\Database\db.sql
    3. change the following files using Step 4 for each.
        ~\Source\DragonNews\DragonNews.Web\ConnectionString.config
        ~\Source\DragonNews\DragonNews.DataAccess\ConnectionString.config
        ~\Source\DragonNewsService\DragonNews.News\ConnectionString.config
        ~\Source\DragonNewsService\FeederWeb\ConnectionString.config
    4. find change the following things
        find 'data source=DRAGON' change 'DRAGON' with <your_host_name>
        find 'user id=sa' change 'sa' with <the_user_who_can_access_the_database>
        find 'password=123' change '123' with <that_users_password>


-Steps to prepare the solution:
--------------------------------
    1. just run the .sln file of 
        DragonNews folder's to see the web part, and
        DragonNewsService folder's to run the service.
    
    [Note: while running the service 'http://localhost:54249/' appiar on browser which gives an error: HTTP Error 403.14 - Forbidden. This is odd and I tried to solve the problem but couldn't. My bad. apolizies]
    
    2. service end point 
        for rss:
            http://localhost:54249/news/rss?category=sports
        for rest:
            http://localhost:54249/news/rest/category/sports
        
    



