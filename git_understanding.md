# Understanding Merge Conflicts in Git

## What Causes Merge Conflicts?

A merge conflict occurs when Git cannot automatically combine changes from two
branches.

This usually happens when two branches modify the same line of the same file,
or when one branch deletes a file while another branch edits it.

Instead of choosing one version automatically, Git pauses the merge and asks
the developer to decide which changes should be kept.

## What Caused the Conflict?

To create the conflict, I first created a new branch called
`conflict-demo` and changed the contents of `merge-conflict-demo.txt`.

I then switched back to the `main` branch and changed the same line in the
same file to different text.

When I merged the `conflict-demo` branch into `main`, Git detected that both
branches had modified the same line differently and could not determine which
version should be kept automatically.

## How Did I Resolve the Conflict?

After Git reported the merge conflict, I opened the conflicted file in Visual
Studio Code.

The file contained conflict markers showing the current version from the
`main` branch and the incoming version from the `conflict-demo` branch.

I removed the conflict markers and replaced them with a single sentence that
combined the intended changes.

After saving the file, I staged the resolved file using `git add`,
completed the merge with `git commit`, and pushed the updated branch to
GitHub.

## What Did I Learn?

This exercise helped me understand that merge conflicts are a normal part of
collaborative software development.

A merge conflict does not mean that Git has failed. Instead, Git stops and
asks the developer to choose the correct final version of the code.

I also learned that keeping branches small, communicating with teammates, and
merging changes regularly can reduce the number of merge conflicts.

## Pull Requests

I learned that Pull Requests allow developers to propose changes without
modifying the main branch directly.

They provide a place for code review, discussion, feedback, and approval before
changes become part of the project.

Using Pull Requests helps teams maintain code quality and reduces the chance of
introducing bugs into the main branch.

## Reviewing an Open-Source Pull Request

I reviewed React Pull Request #37050 ("[DevTools] Validate Store operation invariants").

The author clearly explained the purpose of the change, describing what problem was being solved and why the change was necessary. Before the Pull Request was merged, the author requested a review from another maintainer. The reviewer asked questions about the implementation, particularly regarding the behaviour of Flow's `empty` type compared with TypeScript's `never` type.

Rather than immediately approving the Pull Request, the reviewer and author discussed the implementation until they reached a shared understanding. During this process, the author updated the Pull Request several times by pushing improvements before the reviewer finally approved the changes.

I also observed that the Pull Request included automated checks, regression tests, and continuous integration results before it was merged. After approval, the Pull Request was merged and the feature branch was deleted.

This review taught me that Pull Requests are collaborative discussions rather than simply a way to merge code. They improve code quality, encourage knowledge sharing, and ensure changes are reviewed, tested, and understood before becoming part of the main branch.

## Reflection: PR

## Why are Pull Requests important in a team workflow?

Pull Requests provide a structured way for team members to review changes before they are merged into the main branch. They encourage discussion, catch bugs early, maintain coding standards, and allow knowledge sharing across the team. They also provide a record of why a change was made and who reviewed it.

## What makes a well-structured Pull Request?

A well-structured Pull Request has a clear and meaningful title, a concise description explaining the purpose of the change, a focused scope, appropriate tests where necessary, and references to related issues when applicable. It should be easy for reviewers to understand what changed and why.

## Commit Message Practice

Bad commit messages make project history difficult to understand.

Developers should avoid writing commit titles that are excessively long because they become difficult to read in Git history.
