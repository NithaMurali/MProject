# MProject
Problem Statement:
Imagine you’re writing an order processing application for a large company. In the past, this company used a fairly 
random mixture of manual and ad-hoc automated business practices to handle orders; they now want to put all these 
various ways of hanadling orders together into one whole: your application. After a full day of workshops you have 
gathered the following set of rules which need to be managed by the new system.
• If the payment is for a physical product, generate a packing slip for shipping.
• If the payment is for a book, create a duplicate packing slip for the royalty department.
• If the payment is for a membership, activate that membership.
• If the payment is an upgrade to a membership, apply theupgrade.
• If the payment is for a membership or upgrade, e-mail the owner and inform them of the activation/upgrade.
• If the payment is for the video “Learning to Ski,” add a free “First Aid” video to the packing slip (the result of a court 
decision in 1997).
• If the payment is for a physical product or a book, generate a commission payment to the agent. 

To Run the project:
Install VisualStudio 2019
Clone or download the code
Open the solution BusinessRuleEngineApp.sln in visual Studio 2019
Set BusinessRuleEngineApp as the startup project.
Select the 'Solution COnfiguration' to Debug/Release.
Build and run the code

About the application:
The project is a .net console application.
It simulates the scenario where items are added to cart.
After payment is processed for each item in the cart, the appropriate payment rule will be applied.
The item/product classes are modular. So are the rules applied to each class.
The code is extensible with ability to add new products or rules without affecting the existing classes.
The design allows one to many relationship between product and rule.