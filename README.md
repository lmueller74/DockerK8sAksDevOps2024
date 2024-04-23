# DockerK8sAksDevOps2024
Upgraded to .NET 8
<BR>
<BR>
(Starting at section 6 from original UDEMY course)
<BR><BR>
UDEMY COURSE (no longer maintained)<BR>
https://github.com/aspnetrun/run-devops<BR>
Step by Step Development of this repository:<br>
https://www.udemy.com/course/deploying-net-microservices-with-k8s-aks-and-azure-devops/?couponCode=APRI24<BR>

Upgraded course content for use in 2024 
Added support for mongo / docker
- download docker desktop
- pull mongo image from dockerhub
- run following command to start mongo image in docker desktop 
	(it will be listening on 27017 when you start your app in VS using multipl startup projects)

(from terminal or command prompt):
>docker run -d -p 27017:27017 --name shopping-mongo mongo

