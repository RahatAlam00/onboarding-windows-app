<!-- cspell:ignore Kanban -->

# Agile Principles and Frameworks

## Overview

For this task, I researched Agile software development, the Agile Manifesto, Scrum and Kanban, and how these approaches affect the way a development team works.

I also considered why a Kanban-style workflow is suitable for Focus Bear and how Agile principles can help me work more effectively as part of the team.

## What Is Agile?

Agile is an approach to software development that focuses on delivering useful software incrementally, collaborating closely, receiving feedback, and adapting when requirements or priorities change.

Instead of attempting to plan every detail of a project at the beginning, Agile encourages teams to work in smaller iterations and continuously improve the product.

A simplified comparison is:

```text
Traditional approach

Plan everything
      |
      v
Design
      |
      v
Build
      |
      v
Test
      |
      v
Deliver


Agile approach

Plan
 |
 v
Build a small amount
 |
 v
Test
 |
 v
Deliver / receive feedback
 |
 v
Adapt
 |
 +------> Repeat
```

Traditional project management can work well when requirements are predictable and unlikely to change.

Software development, however, often involves changing requirements, technical discoveries, bugs, user feedback, and changing priorities.

Agile is designed to make responding to these changes easier.

## The Four Values of the Agile Manifesto

The Agile Manifesto defines four core values.

### Individuals and Interactions Over Processes and Tools

Processes and tools are useful, but communication between people is more important.

A development team should not rely only on tickets, documentation, or tools when a conversation could resolve an issue more effectively.

### Working Software Over Comprehensive Documentation

Documentation is valuable, but the main goal of software development is to produce software that actually works.

Documentation should support development rather than becoming a substitute for delivering functioning software.

### Customer Collaboration Over Contract Negotiation

Teams should communicate with customers and stakeholders throughout development rather than relying entirely on requirements established at the beginning.

Feedback can reveal misunderstandings and help ensure that the product solves the correct problem.

### Responding to Change Over Following a Plan

Planning is important, but plans should be adaptable.

If requirements, priorities, technical constraints, or user needs change, the team should be able to adjust rather than continuing with an outdated plan simply because it was originally agreed upon.

The Agile Manifesto does not say that processes, documentation, contracts, or plans have no value. It states that while these things are valuable, Agile places greater emphasis on the items on the left.

## Agile Principles

The Agile Manifesto is supported by twelve principles.

Important themes within these principles include:

- Delivering valuable software early and continuously.
- Welcoming changing requirements.
- Delivering working software frequently.
- Encouraging collaboration between business and development.
- Building projects around motivated people.
- Supporting effective communication.
- Using working software as a primary measure of progress.
- Maintaining a sustainable development pace.
- Paying continuous attention to technical excellence and good design.
- Keeping solutions as simple as possible.
- Allowing teams to organise their work effectively.
- Regularly reflecting and adjusting how the team works.

These principles encourage teams to learn continuously rather than assuming that the original plan will always remain correct.

## Scrum

Scrum is an Agile framework that organises development around fixed periods called Sprints.

A Sprint lasts one month or less and provides a regular cycle in which the team works toward a Sprint Goal.

A simplified Scrum workflow is:

```text
Product Backlog
      |
      v
Sprint Planning
      |
      v
Sprint
      |
      v
Working Increment
      |
      v
Sprint Review
      |
      v
Retrospective
      |
      +------> Next Sprint
```

Scrum defines three accountabilities:

- Product Owner.
- Scrum Master.
- Developers.

It also defines regular events such as:

- Sprint Planning.
- Daily Scrum.
- Sprint Review.
- Sprint Retrospective.

This creates a structured development rhythm.

## Kanban

Kanban focuses on visualising work and maintaining a continuous flow of tasks.

A simple Kanban board may contain:

```text
To Do
  |
  v
In Progress
  |
  v
Review
  |
  v
Done
```

Tasks move across the workflow as work progresses.

An important concept in Kanban is limiting Work in Progress.

Instead of allowing everyone to start many tasks simultaneously, the team limits how much work can be active at once.

For example:

```text
Too much work

Task A -> In Progress
Task B -> In Progress
Task C -> In Progress
Task D -> In Progress
Task E -> In Progress

Result:
Many things started
Few things completed
```

With a Work in Progress limit:

```text
Task A -> In Progress
Task B -> In Progress

Task C -> Waiting
Task D -> Waiting
Task E -> Waiting

Finish A or B
      |
      v
Pull next task
```

This encourages the team to finish existing work before starting additional work.

Kanban therefore focuses strongly on:

- Visualising work.
- Managing flow.
- Limiting Work in Progress.
- Identifying bottlenecks.
- Completing work continuously.
- Improving the workflow over time.

## Scrum vs Kanban

Scrum and Kanban both support Agile ways of working, but they organise work differently.

| Scrum | Kanban |
| --- | --- |
| Work is organised into Sprints | Work flows continuously |
| Sprints have a fixed duration | No Sprint is required |
| Uses a Sprint Goal | Tasks are pulled as capacity becomes available |
| Defines Scrum accountabilities | Does not require Scrum-specific roles |
| Includes prescribed Scrum events | Meetings can be adapted to team needs |
| Work is planned around each Sprint | Priorities can be handled continuously |
| Progress is reviewed within the Sprint cycle | Flow can be monitored continuously |
| Useful when regular iterations provide helpful structure | Useful when work arrives continuously or priorities change frequently |

In my own words, the biggest difference is that Scrum groups work into time-boxed iterations, while Kanban focuses on continuously moving individual tasks through a workflow.

Scrum can be represented as:

```text
Sprint 1
[Task][Task][Task]
        |
        v
Sprint 2
[Task][Task][Task]
```

Kanban is more like:

```text
Task -> Task -> Task -> Task
 |       |       |       |
 v       v       v       v
continuous movement through workflow
```

Neither framework is automatically better than the other. The appropriate approach depends on the type of work and the needs of the team.

## Why Focus Bear Leans Toward Kanban

The onboarding task identifies that Focus Bear leans toward Kanban rather than a strictly Scrum-based workflow.

Kanban is well suited to an environment where work may consist of different types of tasks, such as:

```text
Features
Bug fixes
Technical improvements
Code reviews
Support work
Research
Maintenance
```

These tasks may not always fit neatly into fixed Sprints.

A continuous-flow approach allows work to be prioritised and pulled when team capacity becomes available.

This can be useful for a product team because priorities may change as bugs are discovered, feedback is received, or new product requirements emerge.

Kanban also provides visibility into the current state of work.

For example:

```text
Backlog
   |
   v
Ready
   |
   v
In Progress
   |
   v
Review
   |
   v
Done
```

A team member can quickly see what work is waiting, what is currently being developed, what requires review, and what has been completed.

This explanation is my interpretation of why Kanban characteristics fit the working environment described in the onboarding material. I did not find a public Focus Bear source that gives an official internal explanation for choosing Kanban.

## Benefits of Agile

One major benefit of Agile is adaptability.

Software requirements can change during development. Agile provides a way to respond to these changes instead of treating the original plan as permanent.

Another benefit is faster feedback.

Smaller pieces of work can be reviewed earlier:

```text
Small change
    |
    v
Review
    |
    v
Feedback
    |
    v
Improve
```

This can identify misunderstandings before they become large problems.

Agile also encourages collaboration. Developers, reviewers, stakeholders, and other team members communicate regularly rather than working completely independently.

Another important benefit is visibility. When work is divided into smaller tasks and tracked through a shared workflow, the team can understand what is happening and identify blockers more easily.

## Challenges of Agile

Agile also has challenges.

Frequent changes can become disruptive if priorities change without good communication.

Teams can also misuse Agile as an excuse for having no planning or documentation. Agile does not mean that planning and documentation are unnecessary.

Another challenge is communication. Agile relies heavily on collaboration, which means unclear communication can affect the whole team.

Kanban also requires discipline around Work in Progress. If everyone continuously starts new tasks without completing existing ones, the benefits of continuous flow can disappear.

Teams therefore need to balance flexibility with structure.

## How Agile Can Improve My Work

Agile principles can help me approach development as a continuous learning process.

Instead of trying to solve an entire large problem at once, I can divide work into smaller steps:

```text
Understand task
      |
      v
Make small change
      |
      v
Build / test
      |
      v
Review result
      |
      v
Receive feedback
      |
      v
Improve
```

This makes problems easier to identify and reduces the risk of making many changes before discovering that the approach was incorrect.

Agile also encourages me to communicate when I am blocked rather than spending too long struggling silently.

As a developer, this means I should:

- Keep tasks visible.
- Communicate blockers.
- Ask questions when requirements are unclear.
- Make manageable changes.
- Test my work.
- Respond constructively to review feedback.
- Finish existing work before taking on unnecessary additional work.
- Learn from mistakes and improve my process.

## Agile Principle Most Useful to My Work

The Agile principle I think will be most useful in my work is the principle of regularly reflecting on how to become more effective and then adjusting behaviour accordingly.

This is useful because software development involves continuous learning.

A development task may follow this cycle:

```text
Attempt
   |
   v
Test
   |
   v
Discover problem
   |
   v
Understand cause
   |
   v
Fix
   |
   v
Learn
   |
   +------> Apply lesson next time
```

This principle means that mistakes and feedback can become opportunities to improve the next piece of work.

For example, if a code review identifies a problem, the goal should not only be to fix that individual line of code. I should understand why the issue occurred so I can avoid creating the same problem later.

Regular reflection can therefore improve both technical skills and working habits.

## Reflection on Agile Benefits and Challenges

I think the biggest benefit of Agile is that it accepts that software development involves uncertainty.

Requirements can change, bugs can appear, technical assumptions can turn out to be incorrect, and feedback can reveal better solutions.

Working in smaller increments allows these discoveries to influence development earlier.

I also think Agile can make feedback less intimidating because feedback becomes a normal part of the development cycle rather than something that happens only after a large amount of work has been completed.

The biggest challenge is maintaining enough structure while remaining flexible.

If priorities change constantly without clear communication, developers may struggle to finish work. Similarly, if Agile is interpreted as meaning that planning or documentation is unnecessary, the project can become difficult to maintain.

For Agile to work effectively, flexibility needs to be combined with clear communication, visible work, sensible priorities, and technical discipline.

## Main Scrum and Kanban Differences in My Own Words

Scrum divides work into fixed periods called Sprints. The team decides what it wants to achieve during the Sprint and uses defined Scrum events and accountabilities to organise the work.

Kanban does not require work to be divided into Sprints. Instead, tasks continuously move through a visible workflow, and new work is pulled when capacity becomes available.

I think of the difference as:

```text
Scrum
"When are we delivering the next group of work?"

Kanban
"What should move through the workflow next?"
```

Scrum provides more prescribed structure around time-boxed iterations.

Kanban provides more flexibility around continuous flow while using visibility and Work in Progress limits to keep work manageable.

## Key Takeaways

The main lessons I gained from this research are:

1. Agile focuses on collaboration, working software, feedback, and adapting to change.

2. The Agile Manifesto contains four values supported by twelve principles.

3. Agile does not mean abandoning planning, processes, documentation, or discipline.

4. Scrum organises work into fixed-length Sprints with defined accountabilities and events.

5. Kanban focuses on continuous flow, visualisation, and limiting Work in Progress.

6. Scrum and Kanban are both Agile approaches but organise work differently.

7. Kanban can suit teams where work and priorities change continuously.

8. Limiting Work in Progress helps encourage finishing tasks instead of continuously starting new ones.

9. Agile requires communication and discipline to work effectively.

10. Regular reflection and improvement is an Agile principle that I can apply directly to my own development work.

## Conclusion

Agile provides a flexible approach to software development based on delivering useful work, collaborating with others, responding to feedback, and continuously improving.

Scrum and Kanban apply these ideas differently. Scrum provides a structured Sprint-based framework, while Kanban focuses on continuous flow and managing Work in Progress.

For my work, the most important lesson is that development should be iterative. I should make manageable changes, verify them, communicate with the team, respond to feedback, and use each task as an opportunity to improve how I approach the next one.
