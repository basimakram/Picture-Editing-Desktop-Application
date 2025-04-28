# How to Run This Project

Follow these steps to set up and run the Pixelair project on your local machine:

1. **Add Media Files**  
   - Navigate to the `Pixelair\Media` directory.  
   - Add all the required `.wav` media files into this folder.

2. **Update Media Paths**  
   - Open each form in the project where media files are used.  
   - Update the file paths to correctly point to the media files you added in the `Media` folder.

3. **Set Up the Database**  
   - Locate the `pixelair.sql` script file.  
   - Execute it using SQL Server Management Studio (or a similar tool) to create the database on your local SQL Server instance.

4. **Configure the Connection String**  
   - Open the `App.config` file in the project.  
   - Update the `connectionString` section with your local SQL Server name and database information.

5. **Run the Project**  
   - Open the solution in Visual Studio.  
   - Build the solution to ensure all dependencies are correctly configured.  
   - Press `F5` or click **Start** to run the project.
