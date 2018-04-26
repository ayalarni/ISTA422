#Azure,Chapter 1, Pages 1-31

##Norma I. Ayala-Rosa

1. What are the differences between Iaas, Paas, and Saas?
Software as a service: SaaS is software that is centrally hosted and managed for the end customer. It usually is based on a multitenant architecture—a single version of the application is used for all customers. It can be scaled out to multiple instances to ensure the best performance in all locations. SaaS software typically is licensed through a monthly or annual subscription. Office 365 is one example.

Platform as a service: PaaS, you deploy your application into an application-hosting environment provided by the cloud service vendor. The developer provides the application, and the PaaS vendor provides the ability to deploy and run it. This frees developers from infrastructure management, allowing them to focus strictly on development. 

Infrastructure as a service: IaaS, cloud vendor runs and manages server farms running virtualization software, enabling you to create VMs that run on the vendor’s infrastructure. Depending on the vendor, you can create a VM running Windows or Linux and install anything you want on it. Azure provides the ability to set up virtual networks, load balancers, and storage and to use many other services that run on its infrastructure. You don’t have control over the hardware or virtualization software, but you do have control over almost everything else. In fact, unlike PaaS, you are completely responsible for it.

2. What is the Azure Service Management (ASM) deployment model?
The Azure Service Management (ASM) deployment model has been used to deploy services. In the Azure portal, services managed with ASM are referred to as classic. 

What is the Resource Manager deployment model?
In 2015, Microsoft introduced the Resource Manager deployment model as a modern, more functional replacement for ASM. The Resource Manager deployment model is recommended for all new Azure workload.

3. What is the dierence between a control plane and a data plane?
These deployment models are often referred to as control planes because they are used to control services, not just to deploy them. This is different from a data plane, which manages the data used by a service.

4. What is Role-Based Access Control?
Microsoft introduced RBAC, providing fine-grained control over the operations and scope with which a user can perform a control-plant action. The previous methodology (classic) only allows you to grant either full administrative privileges to everything in a subscription or no access at all.  Example is the nuclear missile system.

5. Why would you want to create a custom role for role-based access control?
With Resource Manager, you can grant permissions at a specified scope: subscription, resource group, or resource. This means you can deploy a set of resources into a resource group and then grant permissions to one or more specific users, groups, or service principal. Those users will only have the permissions granted to those resources in that resource group. This access does not allow them to modify resources in other resource groups. You can also give a user permission to manage a single VM, and that’s all that user will be able to access and administer.

6. Consider the Azure portal. What is the dashboard? The Azure portal is the dashboard.
What is the hub? The column on the left is called a hub; it shows you a core set of options such as Resource Groups, All Resources, and Recent. The other items on this hub are resources you have selected and/or used before.
What is a blade? Marketplace This will take you directly to the Marketplace blade where you can search for and add resources.

7. Access the conceptual Azure documentation on Github. Search the documentation and answer this question: What happens when I reach the spending limit? 

8. Access the Azure samples on Github. Search for an example that will allow you to download an Azure
invoice. Copy the source code to your discussion. (This is Program.cs.)

9. Access the Azure Resource Manager samples on Github. Search for a quickstart template that will allow you to set up a free SQL Database for a web application. This template has four les. One le is a markdown le. What is the type of the other three les?
