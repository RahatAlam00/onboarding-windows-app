<!-- cspell:ignore Kanban -->

# Agile Team Roles

## Overview

For this task, I researched the key roles involved in an Agile software team and how they collaborate.

Although Agile teams can be organised differently depending on the company and framework, successful delivery requires people with different responsibilities to work together rather than operating as isolated departments.

The main roles I considered are:

- Developers.
- Quality Assurance.
- Product Manager.
- Agile Project Manager.
- UX and design.
- Stakeholders.
- Customer support.

I also considered how collaboration differs between Scrum and Kanban and reflected on my own role as a Windows Developer Intern.

## Developers

Developers are responsible for turning product requirements and ideas into working software.

Their responsibilities can include:

- Understanding requirements.
- Designing technical solutions.
- Writing and maintaining code.
- Debugging problems.
- Writing and running tests.
- Reviewing code.
- Maintaining technical quality.
- Communicating technical limitations.
- Responding to review and testing feedback.
- Helping improve the development process.

A developer's responsibility does not end when the code compiles.

A typical development workflow may look like:

```text
Understand requirement
        |
        v
Design solution
        |
        v
Implement
        |
        v
Test
        |
        v
Code review
        |
        v
Respond to feedback
        |
        v
Ready for release
```

Developers therefore collaborate with many other roles throughout the lifecycle of a task.

## Quality Assurance

Quality Assurance, or QA, focuses on helping ensure that the product behaves as expected and meets appropriate quality standards.

QA responsibilities can include:

- Understanding acceptance criteria.
- Designing test scenarios.
- Testing new functionality.
- Testing edge cases.
- Identifying defects.
- Reproducing reported problems.
- Verifying bug fixes.
- Contributing to automated testing.
- Checking for regressions.

A common interaction between development and QA is:

```text
Developer implements feature
          |
          v
Developer tests feature
          |
          v
QA verifies behaviour
          |
          v
Problem found?
       /     \
     Yes      No
      |        |
      v        v
Developer     Work can
investigates  progress
and fixes
      |
      v
QA verifies fix
```

Quality should not be treated as only the responsibility of QA.

Developers, QA, product staff, and the wider team all contribute to product quality.

## Product Manager

A Product Manager focuses on the product and the value it should provide to users and the organisation.

Responsibilities can include:

- Understanding user needs.
- Understanding business goals.
- Helping define product direction.
- Prioritising features and improvements.
- Communicating product requirements.
- Gathering feedback.
- Balancing competing priorities.
- Helping determine which problems should be solved first.

A Product Manager often helps answer:

```text
What problem are we solving?

Why is it important?

Who are we solving it for?

What should be prioritised?
```

Developers then contribute technical knowledge about how the problem can be solved and what constraints may exist.

In Scrum organisations, some product responsibilities may overlap with the Product Owner accountability. The Product Owner is specifically responsible for maximising product value and managing the Product Backlog effectively.

## Agile Project Manager

An Agile Project Manager helps support the delivery process and coordination between people.

The exact responsibilities vary between organisations, but they may include:

- Tracking progress.
- Coordinating work.
- Identifying dependencies.
- Identifying risks.
- Helping resolve blockers.
- Facilitating communication.
- Improving team processes.
- Helping maintain visibility of work.
- Coordinating delivery expectations.

An Agile Project Manager should not simply assign tasks and control every technical decision.

A more Agile approach is to help the team maintain an effective environment in which work can progress.

The role can be thought of as helping move from:

```text
Blocked work
Unclear priorities
Hidden dependencies
Communication problems
```

toward:

```text
Visible work
Clear priorities
Managed dependencies
Better collaboration
```

Agile Project Manager is an organisational role rather than one of the formal Scrum accountabilities.

In Scrum, some process and facilitation responsibilities may overlap with the Scrum Master role.

## UX and Design

UX professionals focus on how users experience and interact with the product.

Their work may include:

- User research.
- Understanding user problems.
- Designing workflows.
- Creating interface designs.
- Creating prototypes.
- Improving usability.
- Considering accessibility.
- Testing designs with users.

Developers and UX designers need to collaborate because a design must eventually become functioning software.

The collaboration may look like:

```text
User need
    |
    v
UX research/design
    |
    v
Developer implementation
    |
    v
Review
    |
    v
User feedback
    |
    +-----> improvement
```

Developers may also identify technical limitations or suggest alternative implementations that achieve the same user goal.

## Stakeholders

Stakeholders are people or groups who have an interest in the product or are affected by it.

They can include:

- Customers.
- Users.
- Company leadership.
- Business partners.
- Product teams.
- Internal departments.
- Other external parties.

Stakeholders can provide information about requirements, priorities, constraints, and expected outcomes.

Agile encourages regular feedback rather than waiting until the end of a long project to discover whether stakeholder expectations were understood correctly.

## Customer Support

Customer support communicates directly with users who experience questions or problems with the product.

This can provide valuable information to the development team.

For example:

```text
Customer experiences problem
          |
          v
Customer support receives report
          |
          v
Problem pattern identified
          |
          v
Product/development informed
          |
          v
Issue investigated
          |
          v
Fix or improvement
```

Support teams can therefore help developers understand how software behaves in real-world situations.

Repeated support requests may also reveal usability problems or opportunities for product improvements.

## Roles in Scrum

Scrum formally defines three accountabilities:

- Product Owner.
- Scrum Master.
- Developers.

The Scrum Team works together toward the Product Goal.

Other skills such as testing, UX, design, security, or analysis can still exist within a cross-functional team, but Scrum does not require separate Scrum roles for each specialist function.

Collaboration is organised around the Sprint and Scrum events.

A simplified workflow is:

```text
Product Backlog
      |
      v
Sprint Planning
      |
      v
Sprint
      |
      +---- Developers
      +---- Testing
      +---- Design
      +---- Collaboration
      |
      v
Sprint Review
      |
      v
Feedback
      |
      v
Retrospective
```

The Sprint creates a regular time-box in which the team works toward a Sprint Goal.

## Roles in Kanban

Kanban does not require the Scrum-specific accountabilities or a fixed Sprint structure.

Existing organisational roles can collaborate through the workflow.

For example:

```text
Backlog
   |
   v
Ready
   |
   v
Development
   |
   v
Review
   |
   v
QA
   |
   v
Done
```

The important focus is the movement of work through the system.

Different people contribute when their skills are needed.

For example:

```text
Product
   |
defines/prioritises work
   |
   v
Developer
   |
implements
   |
   v
Reviewer
   |
reviews
   |
   v
QA
   |
verifies
   |
   v
Done
```

Work in Progress limits can help prevent the team from starting too many tasks simultaneously.

If work becomes stuck in one stage, the visible workflow can make the bottleneck easier to identify.

## Collaboration in Scrum vs Kanban

Scrum and Kanban both require collaboration, but the structure around that collaboration is different.

| Scrum | Kanban |
| --- | --- |
| Collaboration occurs within Sprints | Collaboration occurs continuously |
| Uses defined Scrum accountabilities | Does not require specific roles |
| Uses formal Scrum events | Meetings can be adapted to team needs |
| Work is planned around a Sprint Goal | Work is pulled based on capacity |
| Review occurs within the Sprint cycle | Review can occur as work flows |
| Retrospectives occur as a Scrum event | Improvement can happen continuously |
| Work is grouped into time-boxed iterations | Work moves continuously through workflow stages |

In my own words, Scrum provides a defined rhythm for collaboration, while Kanban allows collaboration to happen around the continuous movement of individual work items.

## My Role in the Agile Team

My role is a Windows Developer Intern.

My main responsibility is to contribute to the Windows application by learning the codebase, implementing assigned work, testing my changes, responding to feedback, and improving my technical skills.

My contribution to the Agile process can be represented as:

```text
Understand task
      |
      v
Clarify requirements
      |
      v
Implement change
      |
      v
Test
      |
      v
Submit for review
      |
      v
Receive feedback
      |
      v
Improve
      |
      v
Complete work
```

Although I am an intern, my work still affects the wider development flow.

If I leave a task unclear, untested, or blocked without communicating it, that can affect other people waiting for the work.

Therefore, contributing effectively means more than writing code.

It also means communicating clearly, keeping work visible, testing changes, responding to reviews, and asking for help when necessary.

## How My Responsibilities Interact With Other Roles

My work overlaps with several roles.

### Product

Product-related roles help explain what problem needs to be solved and why it matters.

As a developer, I need to understand those requirements before deciding how to implement the solution.

If something is unclear, asking questions early can prevent me from building the wrong behaviour.

### Other Developers

Other developers may:

- Review my code.
- Explain parts of the codebase.
- Suggest better implementation approaches.
- Help diagnose technical problems.
- Work on related functionality.

I should make my changes understandable and respond constructively to code-review feedback.

### Quality Assurance

QA may verify whether the functionality I implemented behaves correctly.

This means I need to provide code that has already been tested rather than expecting QA to discover basic development mistakes.

If QA identifies a defect, I need to understand the reproduction steps, investigate the cause, implement a fix, and communicate what changed.

### UX

If my task affects the interface, UX decisions may influence how I implement it.

I may also need to communicate technical limitations or ask questions when expected behaviour is unclear.

### Agile or Project Coordination

If my work is blocked or taking longer than expected, keeping that information visible helps the team respond.

Silently remaining blocked can make planning more difficult.

## Role I Frequently Collaborate With: QA

One role that is particularly important for collaboration with a Windows developer is Quality Assurance.

Both developers and QA are working toward the same outcome:

```text
Reliable software that behaves as expected
```

However, we approach the product from different perspectives.

As a developer, I know how the feature was implemented.

QA can approach it from the perspective of expected behaviour, unusual input, edge cases, and possible failure scenarios.

This difference is useful because developers can unintentionally test software according to how they expect their own implementation to work.

QA may discover scenarios that the developer did not consider.

## Improving Collaboration With QA

I can improve teamwork with QA in several ways.

### Test Before Hand-Off

I should test my own changes before asking QA to verify them.

The workflow should not be:

```text
Write code
    |
    v
Give directly to QA
    |
    v
Let QA find basic problems
```

Instead:

```text
Write code
    |
    v
Build
    |
    v
Developer testing
    |
    v
Code review where appropriate
    |
    v
QA verification
```

### Provide Clear Reproduction Information

When a change needs testing, I should clearly explain:

- What changed.
- How to reach the feature.
- What input should be used.
- What behaviour is expected.
- Any known limitations.
- Important edge cases.

This reduces unnecessary back-and-forth.

### Respond Clearly to Defects

If QA reports a problem, useful information includes:

```text
Steps to reproduce
Expected result
Actual result
Environment
Logs or screenshots
```

I should focus on understanding the behaviour rather than immediately assuming that the problem cannot be reproduced.

### Communicate Fixes

After fixing a defect, I should explain what was changed and which version or build contains the fix so QA knows what needs to be retested.

### Treat Quality as Shared Responsibility

The most important improvement is remembering that QA is not solely responsible for quality.

Quality should be:

```text
Developer responsibility
        +
QA responsibility
        +
Team responsibility
```

Developers should prevent defects where possible, while QA provides another perspective and additional verification.

## Short Description of How My Role Fits Into the Agile Team

As a Windows Developer Intern, I contribute to the Agile team by turning assigned requirements into tested software changes.

My work involves understanding tasks, implementing functionality, debugging problems, testing my changes, participating in code review, responding to feedback, and communicating blockers.

In an Agile environment, I should work incrementally and keep the state of my work visible so that other team members understand what is progressing and where help may be needed.

My role is connected to the rest of the team because the software I develop depends on product requirements, may be influenced by UX decisions, is reviewed by developers, and can be verified by QA.

Therefore, effective development requires both technical work and collaboration.

## Reflection

Learning about Agile roles helped me understand that software development is not a sequence of isolated departments where one person finishes work and simply passes it to someone else.

The roles overlap throughout development.

For example, a developer may need product clarification before implementation, UX input while building the interface, another developer during code review, and QA feedback before the work is considered complete.

This means communication is part of my responsibility as a developer.

I also think collaboration with QA is particularly important because developers and testers can see the same feature differently.

I may naturally focus on whether my implementation works according to the expected path, while QA may deliberately try different inputs and edge cases.

I can improve this collaboration by testing my work before hand-off, providing clear information about the change, responding constructively to defects, and treating product quality as a shared responsibility.

As an intern, I also need to communicate when I do not understand a requirement or when I am blocked. Asking for clarification early is more useful to the team than remaining stuck while the task appears to be progressing.

## Key Takeaways

The main lessons I gained from this research are:

1. Agile software delivery requires collaboration between multiple roles.

2. Developers are responsible for more than writing code; testing, communication, review, and quality are also part of development.

3. QA helps verify behaviour and identify defects and edge cases, but quality is a shared team responsibility.

4. Product Managers help connect user and business needs with development priorities.

5. Agile Project Managers can help coordinate delivery, risks, dependencies, communication, and blockers.

6. UX professionals help ensure that software solves user problems in a usable way.

7. Stakeholders provide important requirements, constraints, and feedback.

8. Customer support can provide valuable information about real problems experienced by users.

9. Scrum formally defines Product Owner, Scrum Master, and Developers as its accountabilities.

10. Kanban does not require specific roles and instead focuses on how work flows through the system.

11. My role as a Windows Developer Intern contributes through implementation, testing, communication, review, and continuous learning.

12. Better collaboration with QA can be achieved through clear communication, developer testing, reproducible information, and shared ownership of quality.

## Conclusion

An Agile team depends on people with different skills working together toward a shared product outcome.

Developers, QA, product staff, project coordination, UX, stakeholders, and customer support each contribute different information and perspectives.

Scrum provides defined accountabilities and a Sprint-based structure for collaboration, while Kanban allows existing roles to collaborate around the continuous flow of work.

As a Windows Developer Intern, my contribution is not limited to writing code. I need to understand requirements, implement and test changes, communicate progress and blockers, participate in review, and work effectively with other roles.

Improving my collaboration with QA is particularly valuable because it can help identify problems earlier and contribute to more reliable software.
