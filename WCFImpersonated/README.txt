
In this scenario, every call to this web service will be on behalf of the caller. That is, the wcf web service will run as the caller.

Once deployed 
-------------
on IIS, the only authenticated allowed must me Windows authentication. ( Disable anonymous )
The application pool identity must be:  ApplicationPoolIdentity
The security to access the directory must be APPLICATION USER(PASS-THROUGH AUTHENTICATION)

This post is very helpful to understand the difference between SECURITY MODE=TRANSPORT and SECURITY MODE=MESSAGE. 
Basically when using message the user credentials and claims are encapsulated in every message while using TRANSPORT 
it is done once at the transport layer.
http://msdn.microsoft.com/en-us/library/ff648863.aspx

Because the Windows authentication is selected on the IIS server. The end use must be authenticated prior calling this WCF methods.

NOTE : 
------
GOOD reference on how to achieve this: http://msdn.microsoft.com/en-us/library/ff650591.aspx

