# Azure#Chapter4Pages101-132

## Norma I. Ayala-Rosa

1. What is Azure Blob Service?
It is a storage account. The word blob is an acronym for binary large object. Blobs are basically files like those that you store on your computer (or tablet, mobile device, etc.). They can be pictures, Microsoft Excel files, HTML files, virtual hard disks (VHDs)—pretty much anything.
The Azure Blob service gives you the ability to store files and access them from anywhere in the world by using URLs, the REST interface, or one of the Azure SDK storage client libraries. Storage client libraries are available for multiple languages, including .NET, Node.js, Java, PHP, Ruby, and Python. 

2. What do you have to do to create Azure Blob Service?
To use the Blob service, you have to create a storage account. Once you have a storage account, you can create containers, which are similar to folders, and then put blobs in the containers. You can have an unlimited number of containers in a storage account and an unlimited number of blobs in each container, up to the maximum size of a storage account, which is 500 TB. The Blob service supports only a single-level hierarchy of containers; in other words, containers cannot contain other containers.
Azure Storage supports three kinds of blobs: block blobs, page blobs, and append blobs.

3. What are some common scenarios where file share can be used?
- Many on-premises applications use file shares; this makes it easier to migrate those applications that share data to Azure. If you mount the file share to the same drive letter that the on-premises application uses, the part of your application that accesses the file share should work without any changes.
- Configuration files can be stored on a file share and accessed by multiple VMs.
- Diagnostic logs, metrics, crash dumps, etc. can be saved to a file share to be processed and analyzed later.
- Tools and utilities used by multiple developers in a group can be stored on a file share to ensure that everyone uses the same version and that they are available to everyone in the group.

4. What is Locally Redundant Storage?
Locally Redundant Storage (LRS) Azure Storage provides high availability by ensuring that three copies of all data are made synchronously before a write is deemed successful. These copies are stored in a single facility in a single region. The replicas reside in separate fault domains and upgrade domains. This means the data is available even if a storage node holding your data fails or is taken offline to be updated.
When you make a request to update storage, Azure sends the request to all three replicas and waits for successful responses for all of them before responding to you. This means that the copies in the primary region are always in sync.
LRS is less expensive than GRS, and it also offers higher throughput. If your application stores data that can be easily reconstructed, you may opt for LRS.
 Geo-Redundant Storage (GRS) GRS makes three synchronous

5. Describe Azure Key Vault.
Azure Key Vault Azure Key Vault helps safeguard cryptographic keys and secrets used by Azure applications and services. You could store your storage account keys in an Azure Key Vault. What does this do for you? While you can’t control access to the data objects directly using Active Directory, you can control access to an Azure Key Vault using Active Directory. This means you can put your storage account keys in Azure Key Vault and then grant access to them for a specific user, group, or application.
Let’s say you have an application running as a Web App that uploads files to a storage account. You want to be really sure nobody else can access those files. You add the application to Azure Active Directory and grant it access to the Azure Key Vault with that storage account’s keys in it. After that, only that application can access those keys. This is much more secure than putting the keys in the web.config file where a hacker could get to them.

6. What is Azure Disc Encryption?
Azure Disk Encryption is integrated with Azure Key Vault to allow you to control and manage the disk encryption keys.
Unlike SSE, when you enable this, it encrypts the whole disk, including data that was previously written. You can bring your own encrypted images into Azure and upload them and store the keys in Azure Key Vault, and the image will continue to be encrypted. You can also upload an image that is not encrypted or create a VM from the Azure Gallery and ask that its disks be encrypted.
This is the method recommended by Microsoft to encrypt your IaaS VMs at rest. Note that if you turn on both SSE and Azure Disk Encryption, it will work fine. Your data will simply be double-encrypted.

7. What is Client Size Encryption?
We looked at client-side encryption when discussing encryption in transit. The data is encrypted by the application and sent across the wire to be stored in the storage account. When retrieved, the data is decrypted by the application. Because the data is stored encrypted, this is encryption at rest.
For this encryption, you can encrypt the data in blobs, tables, and queues, rather than just blobs like SSE. Also, you can bring your own keys or use keys generated by Microsoft. If you store your encryption keys in Azure Key Vault, you can use Azure Active Directory to specifically grant access to the keys. This allows you to control who can read the vault and retrieve the keys being used for client-side encryption.
This is the most secure method of encrypting your data, but it does require that you add code to perform the encryption and decryption. If you only have blobs that need to be encrypted, you may choose to use a combination of HTTPS and SSE to meet the requirement that your data be encrypted at rest.

8. What are some of the things you can do with AzCopy?
Here are some of the things you can do with AzCopy:
- Upload blobs from the local folder on a machine to Azure Blob storage.
- Upload files from the local folder on a machine to Azure File storage.
- Copy blobs from one container to another in the same storage account.
- Copy blobs from one storage account to another, either in the same region or in a different region.
- Copy files from one file share to another in the same storage account.
- Copy files from one storage account to another, either in the same region or in a different region.
- Copy blobs from one storage account to an Azure File share in the same storage account or in a different storage account.
- Copy files from an Azure File share to a blob container in the same storage account or in a different storage account.
- Export a table to an output file in JSON or CSV format. You can export this to blob storage.
- Import the previously exported table data from a JSON file into a new table. (Note: It won’t import from a CSV file.)
As you can see, there are a lot of possibilities when using AzCopy. It also has a bunch of options. For

9. Name three options in the settings blade?
Here are some of the options in the Settings blade:
- Access Keys This shows you your storage account name and the two access keys. From the Access Keys blade, you can copy any of the values to the Windows clipboard. You can also regenerate the storage account access keys here.
- Configuration This allows you to change the replication. Yours is LRS if that’s what you selected when creating the storage account. You can change it here to GRS or RA-GRS.
- Custom Domain This is where you can configure a custom domain for your storage account. For example, rather than calling it robinscompany.blob.core.windows.net, you can assign a domain to it and refer to it as storage.robinscompany.com.
- Encryption This is where you can sign up for the Storage Service Encryption preview. At some point, this will be where you enable and disable SSE for the storage account.
- Diagnostics This is where you can turn on the Storage Analytics and the logging.
- Users This is where you can grant management-plane access for this specific storage account.

10. What did you learn from reading this chapter?
In this chapter, we looked at the four Azure Storage services. We talked about each one, discussed what they are used for, and showed how to create storage accounts and managed the data objects. We’ll also touch briefly on securing your applications’ use of Azure Storage.
