# **University.Solution**
Project Initiated: 2021-01-04<br>
Updated: 2021-01-04

## **Project Description**

This project was created to help us further our knowledge with using join statements to help connect tables in our database. We also were able to get additional practice with using many to many relationships with our tables in our datababse. This application is a univeristy registrar that helps keep track of students and courses. Here is a breakdown of the features it has, their functionality, and their benefits.
* As a registrar, you will be able to enter a student, to help keep track of all students enrolled at this University. The student will be able to provide their name and their date of enrollment.
* As a registrar, you will be able to enter a course, so you can keep track of all of the courses the University offers. You should be able to provide a course name and a course number (ex. HIST100).
* As a registrar, you will to be able to assign students to a course, so that teachers know which students are in their course. A course can have many students and a student can take many courses at the same time.



## **Required for Use**
* C# and .Net Core installed on your local machine. (Developed on .Net Core v2.2.4)
* Console/Terminal access.
* Code Editor like [Visual Studio Code](https://code.visualstudio.com/)


## **Installation Instructions**
Download .Net Core from the following link and follow the installation instructions.
https://dotnet.microsoft.com/download


### **Installing C#, .NET, dotnet script,**
Install C# and .Net according to your operating system below:

**For Mac**
1. Download this .NET Core SDK Software Development Kit. 
2. Open the .pkg file. This will launch an installer which will walk you through installation steps. Use the default settings the installer suggests.
3. Confirm the installation is successful by opening your terminal and running the command <code>$ dotnet --version</code>, which should return the correct version number.

**For Windows (10+)**
1. Download either the the 64-bit .NET Core SDK Software Development Kit
2. Open the file and follow the steps provided by the installer for your OS.
3. Confirm the installation is successful by opening a new Windows PowerShell window and running the command <code>dotnet --version</code> You should see a response with the correct version number.

Install dotnet script with the following terminal command dotnet tool install: 

<code>dotnet-script</code>

**My SQL** 

1) Download and install [MySQL Community Server](https://dev.mysql.com/downloads/mysql/)
 
2) Download and install [MySQL Workbench](https://dev.mysql.com/downloads/workbench/)

**Windows 10 -**

Start by downloading the MySQL Web Installer from the [MySQL Downloads](https://dev.mysql.com/downloads/file/?id=484919) page. (Use the No thanks, just start my download link.)

Follow along with the installer:

1) Click "Yes" if prompted to update.
2) Accept license terms.
3) Choose Custom setup type.
4) When prompted to Select Products and Features, choose the following:
* MySQL Server 8.0.19 (This will be under "MySQL Servers > MySQL Server > MySQL Server 8.0")

* MySQL Workbench 8.0.19 (This will be under "Applications > MySQL Workbench > MySQL Workbench 8.0")

5) Select "Next", then "Execute". Wait for download and installation. (This can take a few minutes.)

6) Advance through Configuration as follows:

* High Availability set to "Standalone".

* "Defaults are OK" under Type and Networking.

* Authentication Method set to Use Legacy Authentication Method.

* Set password to something you will remember. 

* Defaults are OK under Windows Service. Make sure that checkboxes are checked for the options "Configure MySQL Server as a Windows Service" and "Start the MySQL Server at System Startup". Under Run Windows Service as..., the "Standard System Account" should be selected.

7) Complete Installation process.
Next, add the MySQL environment variable to the System PATH. We must include MySQL in the System Environment Path Variable. This is its own multi-step process:

8) Open the Control Panel and visit System and "Security > System". Select "Change Settings" and a pop-up window will display. Select the tab "Advanced" and select the "Environment Variables" button.
9) Within the System Variables navigator window, select PATH..., click Edit..., and then New.

10) Add the exact location of your MySQL installation, and click OK. (This location is likely C:\Program Files\MySQL\MySQL Server 8.0\bin, but may differ depending on your specific installation.)

**MacOS -**

Start by downloading the MySQL Community Server .dmg file from the [MySQL Community Server page](https://dev.mysql.com/downloads/file/?id=484914). Click the download icon. Use the No thanks, just start my download link.

Next, follow along with the Installer until you reach the Configuration page. Once you've reached Configuration, select or set the following options (use default if not specified):

1) Use Legacy Password Encryption.

2)  Set password to something you will remember.

3) Click Finish.

4) Open the terminal and enter the command echo 'export PATH="/usr/local/mysql/bin:$PATH"' >> ~/.bash_profile. This will save this path in .bash_profile, which is where our terminal is configured.

5) Type in source ~/.bash_profile (or restart the terminal) in order to actually verify that MySQL was installed.

Next, verify MySQL installation by opening terminal and entering the command mysql -uroot -pepicodus. You'll know it's working and connected if you gain access and see the MySQL command line. If it's not working, you'll likely get a -bash: mysql: command not found error.

You can exit the mysql program by entering exit.

Next, download the MySQL Workbench .dmg file from the MySQL Workbench page. (Use the No thanks, just start my download link.)

Install MySQL Workbench to Applications folder.

Then open MySQL Workbench and select the Local instance 3306 server. You will need to enter the password you set. (We used epicodus.) If it connects, you're all set.


### **Opening Locally** ###

**Option 1** (download zip file)
1) Copy and paste the following GitHub project link into your web browser's url bar and hit enter/return. https://github.com/RMGit-it/University.Solution.git
2) Download a .zip copy the repository by clicking on the large green "Code" button near the upper right corner of the screen.
3) Right click the .zip file and extract(unzip) it's contents.
4) Open your computer's terminal/console, and navigate to folder called "__University.Solution__". 
5) Once there, type the following code and hit enter/return to install the necessary dependencies. 

    <code>dotnet restore</code>

6) Once the dependencies have installed, you can type the follow code to launch the program...

    <code>dotnet run</code>

    The program should launch using your default web browser at URL: localhost:5000.

**Option 2** (via git console/terminal)
1) Open your Git enabled terminal/console and navigate to a directory that you wish to download this project to.
2) Type the following line of code into your terminal/console to automatically download the project to your current direcory and hit return/enter

    <code>git clone https://github.com/RMGit-it/University.Solution.git</code>

3) Once the project has finished downloading, use the terminal/console to navigate to the "__University.Solution__" folder of the project.

4) Once there, type the following code and hit enter/return to install the necessary dependencies. 

    <code>dotnet restore</code>
    

5) Once the dependencies have installed, you can type the follow code to launch the program...

    <code>dotnet run</code>

    The program should launch using your default web browser at URL: localhost:5000.

## **Usage / Examples**

## **Planned Features**
No new features are planned at this time.

## **Known Bugs**
There are no known bugs

## **Technology Used**
* C# 7.3
* .NET Core 2.2
* Entity
* Git
* MySQL
* CSS
* HMTL
* Bootstrap
* Razor
* dotnet script, REPL
  
## **Authors and Contributors**
Authored by: Randel Moore, Ryland Adams, Svea Wade & Sarah Gilbert

## **Contact**
RMGit.it@gmail.com

Rylandadams@yahoo.com

svealinneawade@gmail.com 

sarahgilbert064@gmail.com

## **License**

GPLv3

Copyright © 2020 Randel Moore, Ryland Adams, Svea Wade & Sarah Gilbert