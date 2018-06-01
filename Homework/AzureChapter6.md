# Azure#Chapter6Pages157-180

## Norma I. Ayala-Rosa

1. What is the target of Azure SQL Databases.
Azure SQL Database provides a relational database as a service, targeted at online transaction processing (OLTP; that is, data entry and retrieval transactions) workloads. This falls firmly in the platform as a service (PaaS) category of cloud computing. Using SQL Database enables you to give up the physical management responsibilities of a database server but retain the vast majority of logical management and administrative responsibilities. SQL Database provides many attractive features, such as elastic scale, predictable performance, business continuity, near-zero maintenance, and the use of familiar development languages and tools.

2. By default, how many logical SQL Database servers can you have per Azure subscription?
One can have up to six logical SQL Database servers per Azure subscription. Each server can host a maximum of 5,000 databases and 45,000 DTUs. The default limits are soft limits, and they can often be raised by submitting a support ticket with Azure Support.

3. Why does the connection string set the TrustServerCertificate property to False and the Encrypt property to True?
Note that the connection string sets the TrustServerCertificate property to False and the Encrypt property to True. This is to provide additional protection while accessing SQL Database over the Internet. Doing so helps thwart potential man-in the-middle attacks. SQL Database will force the connection to be encrypted regardless of the setting.

4. What are transient errors?
Transient errors are errors that are intermittent and likely will be resolved if the command is retried. These errors are more common with SQL Database than with databases accessed via a local area network (LAN). This is due to the inherently unreliable network that is the Internet and the fact that as a managed service, SQL Database might periodically undergo maintenance activities that could cause connections to drop temporarily.

5. What three things contribute to the total cost for running a SQL Server deployment on Azure Virtual Machines?
First is the cost of the Windows VM itself. Recall that Azure VMs are charged on a per-minute usage model. Second is the SQL Server license cost. When using a SQL Server image from the Azure Marketplace, you will pay an additional per-minute SQL Server license cost, which varies according to the version of SQL Server (Web, Standard, or Enterprise) and the target size of the VM. Finally, you’ll also pay for the Azure Storage cost. Azure Storage (specifically page blobs) is used as the persistence mechanism for Azure Virtual Machines disks. To summarize, the cost for SQL Server in Azure Virtual Machines can be represented as Total cost = Windows Server cost + SQL Server license cost + Azure Storage cost.

6. Why do you need to be concerned about high availability and disaster recovery for SQL Server in Azure Virtual Machines?
Azure provides high-availability features for the VMs, but not necessarily for SQL Server running on the VM. It is possible for the VM to be online but the SQL Server instance to be offline, unhealthy, or both. Additionally, it is possible for the VM to unavailable due to hardware failure or software upgrades. Therefore, a practiced HADR strategy should be considered.

7. What are six SQL Server features that are not currently supported in SQL Database (according to the book)?
The features not supported are: Windows authentication, FILESTREAM data, Database mirroring, Extended stored procedures, SQL Server Agent/Jobs, SQL Server Reporting Services (SSRS) and SQL Server Integration Services (SSIS) are not supported. Alternatively, run a SQL Server on-premises or in an Azure VM and connect to a SQL database.

8. Name four factors to consider when choosing between SQL Database and SQL Server in Azure Virtual Machines.
There are many factors to consider when choosing between SQL Database and SQL Server in Azure Virtual Machines: database size, existing application versus new application, level of administrative control (including hardware infrastructure), business continuity strategy, and hybrid scenarios, just to name a few. SQL Database is often the right solution for cloud-designed applications that are not using unsupported features and for which near-zero administration is a key priority. SQL Server in Azure Virtual Machines is often the right choice for new or existing applications that require a high level of control and customization (that is, full compatibility with SQL Server) and for which there is a desire to no longer maintain on-premises hardware.

9. Who did Microsoft collaborate with to bring their ClearDb database as a service for MySQL to the Azure platform?
Microsoft has collaborated with SuccessBricks to bring SuccessBricks’ ClearDb database as a service for MySQL to the Azure platform.

10. What two options exist in Azure if you don't need a relational database management system (RDBMS)based data storage solution such as SQL Database or SQL Server in Azure Virtual Machines?
There are many database options available in the market today. The Microsoft Azure platform makes it easy to run a wide range of popular databases—you don’t have to run SQL Database or Microsoft SQL Server. As discussed in Chapter 3, you can run the software of your choosing on an Azure VM, including the database platform you desire. You also have the option to run MySQL as a service via Microsoft’s partnership with SuccessBrick’s ClearDb offering. If a relational database management system (RDBMS) is not what you’re after, using a NoSQL service such as DocumentDB or Azure Table storage is also an option.