Topshelf Key Concepts
=====================

Setting up services in Windows is painful. It requires you inherit from the nasty ServiceBase
class. Which makes testing them difficult. Then trying to run a service from the command line
or from the service usually takes a little setup. We wanted something simplier and easier.

**Welcome to Topshelf**


Services
--------

Services are typically run unattended by the Windows SCM

Lifecycle
---------

Services can have life cycles such as 'Start' and 'Stop' and we try to help structure
that for our users.

