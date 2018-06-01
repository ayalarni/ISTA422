# Azure#Chapter5Pages133-156

## Norma I. Ayala-Rosa

1. What is a VNET and what is it used for in Azure?
Virtual networks (VNets) are used in Azure to provide private connectivity for Azure Virtual Machines (Azure VMs) and some Azure services. VMs and services that are part of the same virtual network can access one another. By default, services outside the virtual network cannot connect to services within the virtual network. You can, however, configure the network to allow access to the external service.
Services that talk to each other within a virtual network do not travel through the Azure Load Balancer, which gives you better performance. It’s not significant, but sometimes every little bit counts.

2. The fully managed service in Azure that is used for cross-premises connectivity, is called what? A Virtual Network Gateway, it gives you flexibility when connecting one or more on-premises sites with your virtual networks. For example, it gives you the ability to have cross-region geo-redundancy, such as SQL Always On across different Azure regions.

3. List three things you need to know when setting up a virtual network.
When creating a virtual network, there are a few things you need to know, such as the address space, subnets, and DNS servers that you want to use.

4. What is the primary purpose of establishing a subnet?
After specifying your virtual network address space(s), you can create one or more subnets for your virtual network.

5. When in the deployment process of multiple Virtual Machines(VMs) are the VMs assigned their IP address?
VMs are assigned an IP address when they are deployed. If you deploy multiple VMs into a virtual network or subnet, they are assigned IP addresses as they boot up. A dynamic IP address (DIP) is the internal IP address associated with a VM. You can allocate a static DIP to a VM. If you do this, you should consider using a specific subnet for static DIPs to avoid accidentally reusing a static DIP for another VM.

6. Why should you set the location of the Resource Group?
Now let’s create the storage account. You want to create a Resource Manager storage account and specify the resource group. You also specify the storage account name, the location, and the type, which is for the redundancy type. You want to use locally redundant storage for the same reasons mentioned when creating the storage account using the Azure portal. Select your own storage account name.

7. What are the four rules to editing a template to redeploy? These rules are:
- If you remove a resource from the template that is not in the resource group, that resource will be unchanged. It won’t be removed simply because it’s gone from the template. (If you want to remove a resource, you have to specifically remove it using the Azure portal, PowerShell, the Azure CLI, etc.)
- If you add a resource to the template that is not in the resource group, it will create that resource for you when you redeploy the template.
- Resources that are unchanged but are still in the template will be ignored.
- Resources that are changed and still in the template will be updated. For example, if we change the address prefixes of our virtual network and redeploy the template, it will change them in the deployed VNet.

This means you can repeatedly edit a template and add or change a section, and when you redeploy it, it applies the changes and ignores the current (unchanged) specs for the other resources.

8. Why should you not request a complete deployment using PowerShell?
If you use PowerShell, you can also do a complete deployment, which does delete resources that are in the resource group but not in the template when you redeploy. You can’t do complete deployments through the Azure portal. It’s safer to delete the resource group yourself (and verify that that’s what you want to do) than to request a complete deployment. What if you accidentally remove a section from your template? It will remove that resource, and you can’t recover it. If you’re not convinced that it’s dangerous, think about the consequences if you accidentally remove a storage account in which you’ve already stored data. Ouch.

9. Why did Microsoft create NSGs?
Microsoft created NSGs to provide a flexible method for defining the access rules allowing traffic into and out of a VM in a VNet—or even an entire subnet in the VNet. When a Windows Server with a public IP address is created in the portal, an NSG is created that blocks all inbound Internet traffic except RDP on port 3389. Similarly, for a Linux VM with a public IP address, the default NSG created blocks all inbound traffic from the Internet except SSH on port 22. You have to specifically open any other ports you want open, including HTTP and HTTPS. If you do nothing, you are protected by default. The same set of rules can be applied to a single VM or multiple VMs. You can also apply an NSG to a subnet, which applies it to all of the VMs in that subnet.

10. What is a VPN according to the book?
A VPN Gateway is an Azure managed service that is deployed into a VNet and provides the endpoint for VPN connectivity for point-to-site VPNs, site-to-site VPNs, and ExpressRoute. This gateway is the connection point into Azure from either the on-premises network (site-to-site) or the client machine (point-to-site). You’ll see how to do this when we set up a point-to-site network later in this chapter.