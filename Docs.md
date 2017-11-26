# QnA - QnA

## Vision

I would like to create an app that allows users to easily create polls that they can send to a group of friends to gather their opinion on a matter or find the most popular decision from a set of options or activities. This person is the Initiator of the Question. Each friend then receives a notification that they have been prompted with a question and will see the options provided for them by the first user. These people are the Receivers. They each select their answer and submit. The initiator then can see the aggregate responses in real time and make a decision accordingly.



The initial intention for this was to help a group of friends decide what kind of activity to partake in together. What kind of food to eat on a night out for dinner, what movie to go to, what sport to play, etc. It can also be used for simple decisions such as what to name their band or (by setting a condition where each answer can only be selected once) what to bring to a potluck.



## Appendix


- **User**: Any user using the app that is not yet involved in a particular Poll

- **Initiator**: The person that creates the Poll by writing the Question, inputs the possible Answers, selects the Respondents that they wish to prompt for responses and submits

- **Respondent**: A person that the Initiator requested an Answer from when creating the Poll

- **Poll**: A complete package including a Question, its possible Answers and the prompted Respondents.

- **Question**: The question that the Initiator is seeking answers for

- **Answer**: One of the possible responses to the Question created by the Initiator and provided to the Respondents

- **Answers**: The set of all possible responses to the Questions created by the Initiator and provided to the Respondents.

- **Friend**: Someone who is friends with the User. The User can see their public info such as their public Questions and Answers and Profile.

- **Viewer**: Someone who is currently viewing a Poll. If the Poll is Private, these will only be Respondents. If the Poll is Public, this could be a Respondent or a Friend.

- **Privacy**
    - Global Poll: A Poll that may appear in everyone's news feed

    - **Public Poll**: A Poll that will appear in the Initiator's Friends' news feed

    - **Private Poll**: A Poll that will not appear in the Initiator's Friends' news feed


- **Openness**
    - **Open Poll**: A Poll that will appear in the Initiator's Friends' news feed AND which will allow Friends that were not initially selected as Respondents to also participate. Note that an Open Poll CANNOT be Private.

    - **Closed Poll**: A Private Poll OR a Public Poll that will NOT allow Friends that were not initially selected as Respondents to also participate.


- **Transparency**:


    - **Transparent Poll**: A Poll that allows Viewers to see which Respondent selected which Answer in real time, just like the Initiator can.

    - **Translucent Poll**: A Poll that allows Viewers to see the total number of times a particular Answer has been selected by a Respondent, but not who those Respondents are

    - **Opaque Poll**: A Poll that only allows Viewers to see the list of Answers with no real time info about who selected what.


- **Editability**: A Poll whose Respondents are allowed to add their own Answers


    - **Promptable**: A Poll whose Respondents are allowed to suggest a new Answer but these Answers will only be added after accepted by the Initiator

    - **Immutable**:  A Poll whose Answers are locked and can only be edited by the Initiator


Status


Active Poll: A Poll that is still awaiting responses from some of the Respondents

Completed Poll: A Poll that has received all requested responses from all Respondents.


Views



Dashboard



The Dashboard will consist of 3 panels whose visibility is controlled by tabs on the bottom of the screen:


The Feed: Displays Polls that the User's Friends are participating in, either as Initiators or Participants. Upon clicking on a Poll, it will open the Poll View

The User's Active Polls ' Polls that are still running in which the User is either an Initiator or a Respondent. Each Poll will be appropriately labeled with the User's role. Upon clicking on one Poll, it will open the Poll View

The User's Completed Polls ' Polls that the User has participated in in the past, either as an Initiator or Respondent. Each Poll will be appropriately labeled with the User's role. Upon clicking on one Poll, it will open the Poll View



Poll View



The Poll View is displayed when the user clicks on a Poll in the Feed, the Active Poll Panel or the Completed Poll Panel. It will display:


The Initiator and list of Respondents

The Question

The Answers with


The number and list of Respondents that selected each Answer underneath it if the Poll is Transparent

The number of Respondents that selected each Answer next to it if the Poll is Translucent

Just the Answers if the Poll is Opaque


Whether or not the current User is the Initiator or one of the Respondents

If the User is the Initiator ' show a 'Close' button to terminate the Poll with the Answers as they currently stand.

If the User is requested to take action ' ie if he is a Respondent that has not yet selected an Answer to the Question


There should be an appropriate flag on the question:

There should be a 'Withdraw' button to remove himself from the list of Respondents to this question


A flag if the User is able to take action ' ie if the Poll is Open and the User is able to provide an Answer but has not yet done so. Note that since the User is not a Respondent in this case, he is not required to take action for the Poll to be able to close. This is therefore a less important course of action so the flag should be less prominent as the Requested Action Flag.


Process



Opening the App



Upon opening the app, a User is presented with the Feed. Also, 


If he is a Respondent to any Active Questions, there should be a notification on the 

Active Polls tab.

If he is a Respondent to any Active Polls that he has not yet responded to, the notification on the Active Polls tab should display the number of such Polls.



Creating a new Poll




The Initiator of the Poll opens the app and select 'Create New Poll'.

He is presented with the Create Screen prompting him to write the Question, and provide the possible Answers. Answers can be text, images from camera or gallery, or a combination of both.

He is presented with the Config Screen to input the Poll's Privacy (Global, Public or Private), Openness (Open or Closed), Transparency (Transparent, Translucent, or Opaque), Editability (Editable, Promptable, or Immutable) and which Notifications he wishes to receive (see list of Optional Notifications in the Initiator Notifications section). 

He is presented with a screen displaying a list of all his Friends prompting him to check which ones he wishes to make Respondents to the Poll.

He then submits



Notifications



## Initiators

Notifications should be sent to Initiators when:


- A Respondents answers a Poll (optional)

- A Respondents withdraws from a Poll (optional)

- All Respondents have answered a Poll 

- There is a definite majority of answers ' ie not all Respondents have provided an Answer, but over 50% of all Respondents have already selected one of the Answers and it's no longer possible for another Answer to Win. 

- A Respondent has added a new Answer in an Editable Poll (optional)

- A Respondent requests a new Answer in a Promptable Poll

- A Friend responds to a Poll (Optional)



## Respondents

Notifications should be sent to Respondents when:

- They are set as a Respondent to a Poll
- A Poll they answered to is Complete/Closed
