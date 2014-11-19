
In this scenario the end user identity, that is the web user, will be used to call the wcf web service. ( see home controller about method )

1- Add a service reference to the deployed : WCFImpersonated service.
2- Look into the home controller.

Note : 
-The call to the wcf will not work unless the service is deployed on IIS server
-On IIS the Authentication must be set to Windows only , anonymous must be disabled.
