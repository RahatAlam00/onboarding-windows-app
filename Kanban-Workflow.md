<!-- cspell:ignore Kanban -->

# Agile Workflows and Kanban

## Overview

For this task, I researched how Kanban boards are used to manage Agile workflows and created a Kanban board for my Focus Bear onboarding repository.

I configured the board with workflow stages that represent the actual progress of an onboarding task:

```text
Not Started
     |
     v
In Progress
     |
     v
Ready for Review
     |
     v
Approved by Bot
     |
     v
Done
```

I then began using the board to track a real onboarding issue rather than creating a demonstration-only task.

## What Is a Kanban Board?

A Kanban board is a visual representation of work moving through a workflow.

Each task appears as an item or card, and columns represent different states in the work process.

For example:

```text
Not Started    In Progress    Ready for Review    Done

Task A         Task B         Task C
Task D
Task E
```

As work progresses, its card moves between the columns.

This allows the team to quickly understand:

- What work is waiting.
- What work is currently active.
- What work is waiting for review.
- What work is blocked or delayed.
- What work has been completed.

The board therefore makes the current state of work visible rather than requiring team members to remember the status of every task.

## How a Kanban Board Helps Manage Workflow

A Kanban board helps manage workflow by making work and its current state visible.

Without a board, several tasks may exist at the same time without a clear understanding of their status.

For example:

```text
Task A - ?
Task B - ?
Task C - ?
Task D - ?
```

With Kanban:

```text
Not Started    In Progress    Review    Done

Task D         Task A         Task B    Task C
```

The second example immediately provides more information.

A team can see where work is accumulating and identify potential bottlenecks.

For example, if many tasks are waiting for review:

```text
In Progress    Ready for Review

Task A         Task B
               Task C
               Task D
               Task E
```

the problem may not be that development is too slow. The workflow may instead need additional review capacity.

Kanban therefore encourages teams to manage the flow of work rather than only counting how many tasks have been started.

## What Kanban Columns Represent

Columns represent meaningful stages in the team's workflow.

The exact columns depend on how the team works.

For my onboarding board, I created the following statuses.

### Not Started

The task exists and may be ready to work on, but active work has not started.

```text
Task created
     |
     v
Not Started
```

### In Progress

The task is actively being worked on.

For a development task, this could include:

- Research.
- Implementation.
- Debugging.
- Testing.
- Documentation.

### Ready for Review

The person completing the task believes the required work is finished and it is ready for another person or review process to examine.

```text
Implementation
     |
     v
Testing
     |
     v
Documentation
     |
     v
Ready for Review
```

### Approved by Bot

For my onboarding workflow, this represents the stage where the required automated or bot review has approved the work.

It separates:

```text
"I have finished my work"
```

from:

```text
"The work has passed the required review"
```

This gives the review process its own visible state.

### Done

Done represents work that has completed the required workflow.

For my onboarding process, this should only happen after the task has actually completed its required work and review process.

## Blocked Work

Some Kanban boards also use a separate `Blocked` column.

Another approach is to keep the item in its current workflow stage but mark it as blocked.

The important point is that blocked work should be visible.

For example:

```text
In Progress

Task A
BLOCKED: waiting for requirement clarification
```

Making blockers visible helps the team identify work that cannot move forward.

## How Tasks Move Through the Board

Tasks should move when their real status changes.

A task should not be moved simply to make the board appear more complete.

For example:

```text
Task has not started
        |
        v
Not Started

Developer begins work
        |
        v
In Progress

Work completed
        |
        v
Ready for Review

Review approved
        |
        v
Approved by Bot

Completion requirements satisfied
        |
        v
Done
```

This means the board acts as a representation of reality.

If a task is actively being worked on but still appears under `Not Started`, the board is inaccurate.

Similarly, moving unfinished work to `Done` would make the board misleading.

## Who Is Responsible for Updating Tasks?

The person working on a task should normally help keep its status current.

Other team members or automated processes may also update a task when its state changes.

For example:

```text
Developer
    |
starts task
    |
    v
In Progress

Developer
    |
finishes implementation
    |
    v
Ready for Review

Reviewer / review process
    |
approves work
    |
    v
Approved

Completion
    |
    v
Done
```

The exact responsibility depends on the team's workflow.

The important principle is that the board needs to remain accurate.

A Kanban board that is not updated loses much of its value because other team members can no longer trust what it shows.

## Work in Progress

Work in Progress, or WIP, refers to work that has been started but has not yet been completed.

For example:

```text
In Progress

Task A
Task B
Task C
Task D
Task E
```

If one person is responsible for all five tasks, their attention may constantly switch between them.

This can result in:

- Reduced focus.
- More context switching.
- More unfinished work.
- Slower completion.
- Forgotten tasks.
- Difficulty identifying blockers.

## Limiting Work in Progress

A WIP limit restricts how many tasks should be active in a particular workflow state.

For example:

```text
WIP limit = 2

In Progress

Task A
Task B

Waiting:

Task C
Task D
Task E
```

Instead of starting Task C immediately, the developer first tries to finish Task A or Task B.

Once capacity becomes available:

```text
Task A -> Done

Capacity available
       |
       v
Task C -> In Progress
```

This creates a pull-based workflow.

New work is pulled into active development when capacity is available rather than continuously starting additional tasks.

## Benefits of WIP Limits

### Better Focus

Fewer active tasks allow more attention to be given to each task.

### Less Context Switching

Switching repeatedly between unrelated tasks requires mental effort.

Reducing active work can reduce this overhead.

### More Completed Work

Kanban encourages:

```text
Stop starting
Start finishing
```

Completing existing work is usually more useful than having many partially completed tasks.

### Earlier Detection of Blockers

If a small number of tasks remain in progress for a long time, it becomes easier to notice that something is preventing them from moving.

### Better Workflow Visibility

When WIP is controlled, accumulation in a particular stage becomes more meaningful and can reveal a bottleneck.

## How Kanban Helps Manage Priorities

Kanban separates work that could be done from work that is currently being done.

For example:

```text
Not Started

Priority 1
Priority 2
Priority 3
Priority 4

        |
        | capacity becomes available
        v

In Progress

Priority 1
```

Lower-priority work can remain visible without requiring the developer to actively work on everything simultaneously.

When capacity becomes available, the next appropriate item can be selected.

This allows priorities to change without requiring every task to become active.

## How Kanban Helps Avoid Overload

Without WIP awareness, it can be tempting to respond to every new task by immediately starting it.

For example:

```text
New bug       -> Start
New feature   -> Start
Review task   -> Start
Research task -> Start
Documentation -> Start
```

The result can be many unfinished tasks.

Kanban encourages a different question:

```text
Do I have capacity to start this?
```

If the answer is no, the task can remain visible in the backlog or `Not Started` state until existing work progresses.

This provides a simple mechanism for protecting focus.

## Kanban Board Created for My Repository

For this task, I created a GitHub Project named:

`Focus Bear Onboarding Kanban`

The board contains onboarding issues from my repository.

I configured the workflow with these columns:

```text
Not Started
In Progress
Ready for Review
Approved by Bot
Done
```

These columns were selected because they represent the important states in my onboarding workflow.

Initially, the imported issues appeared in the default `Todo` state.

I renamed this status to `Not Started` and added the additional review-related workflow states.

## Moving a Real Task Through the Kanban Process

Rather than creating an artificial example, I used the current onboarding issue:

`Agile Workflows & Kanban`

The task initially appeared under:

```text
Not Started
```

At that point, this was accurate because I had not begun completing the task.

After beginning the research and setting up the Kanban workflow, I moved the issue to:

```text
In Progress
```

The movement therefore represented an actual change in task state:

```text
Agile Workflows & Kanban

Not Started
     |
     | Work begins
     v
In Progress
```

I intentionally did not immediately move the issue through every remaining column.

It should only move to `Ready for Review` after the required work is completed.

It should only move to `Approved by Bot` when the required review has actually approved it.

It should only move to `Done` when the complete task workflow has finished.

This makes the board an accurate record of progress rather than a checklist where statuses are changed prematurely.

## Example of a Paused Task

The board also helped demonstrate why accurate task tracking matters.

A task that is not currently being worked on should not remain marked as actively progressing.

If a task is waiting for information or clarification, its status should reflect that situation rather than giving the impression that active work is continuing.

This makes it easier to distinguish between:

```text
Work I could do later

and

Work I am actively doing now
```

## One Improvement I Can Make to Task Tracking

One improvement I can make is to keep only one primary onboarding issue actively `In Progress` whenever practical and update its board status as soon as its real state changes.

My workflow can therefore be:

```text
Choose task
    |
    v
Move to In Progress
    |
    v
Focus on task
    |
    v
Complete required work
    |
    v
Move to Ready for Review
    |
    v
Respond to review
    |
    v
Approved
    |
    v
Done
    |
    v
Choose next task
```

This would reduce the chance of starting several onboarding tasks and losing track of which one should receive my attention.

It would also make my progress more visible to other people.

## How I Can Improve My Workflow Using Kanban

I can apply several Kanban principles to my own work.

### Keep Status Accurate

I should update a task when its actual state changes rather than waiting until much later.

### Limit Active Work

Where possible, I should finish the current task before beginning another unrelated task.

### Make Blockers Visible

If I cannot continue because I need clarification or assistance, I should record or communicate the blocker.

### Use Review as a Real Workflow Stage

Submitting work is not the same as completing it.

Keeping `Ready for Review` separate from `Done` reminds me that feedback may still require additional work.

### Respond to Feedback Before Starting More Work

If review feedback arrives, completing that feedback loop can be more valuable than beginning several new tasks.

### Keep the Board Trustworthy

The board should show the real state of my work.

If the board says something is `Done`, another team member should be able to trust that the required process has actually been completed.

## Reflection

Kanban makes work easier to understand because it turns an invisible list of responsibilities into a visible workflow.

The most useful concept for me is limiting Work in Progress.

It can be tempting to start another task when the current one becomes difficult or when a new task appears interesting. However, repeatedly starting work can create several partially completed tasks.

Kanban encourages me to focus on moving existing work toward completion.

I also learned that updating the board is part of the work itself.

If I make progress but do not update the task, other team members cannot easily see that progress. If I become blocked but the board still suggests that everything is progressing normally, the team may not know that assistance is required.

Using separate states for `Ready for Review`, `Approved by Bot`, and `Done` is also useful because it makes clear that finishing my own implementation is not necessarily the end of the workflow.

Review and approval are part of completing the task.

## Key Takeaways

The main lessons I gained from this task are:

1. A Kanban board visualises work as it moves through a workflow.

2. Columns represent meaningful states rather than individual team members.

3. Tasks should move when their real status changes.

4. People working on tasks should help keep their status accurate.

5. Work in Progress represents work that has started but has not finished.

6. WIP limits help reduce overload and context switching.

7. Kanban encourages finishing existing work before continuously starting new work.

8. Visible workflows make blockers and bottlenecks easier to identify.

9. Priorities can remain visible without requiring every task to become active.

10. Review and approval can be represented as separate workflow stages.

11. A Kanban board is useful only when its information can be trusted.

12. I can improve my own workflow by limiting active onboarding work and updating task statuses when their real state changes.

## Conclusion

Kanban provides a simple but useful way to manage work by visualising its progress and controlling how much work is active at one time.

Creating a GitHub Project for my onboarding repository helped me see how these principles apply to a real workflow.

Instead of treating every issue as simply open or closed, the board can show whether a task has not started, is actively being worked on, is waiting for review, has received approval, or is fully complete.

The most important improvement I can make is to keep my active work limited and make sure the board reflects reality. This should help me maintain focus, communicate progress more clearly, and avoid accumulating multiple partially completed tasks.
