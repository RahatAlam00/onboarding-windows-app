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

Well-written commit messages make it easier to understand a project's history, review changes, and identify when features or bugs were introduced.

### Commit History Observation

While exploring the React repository, I noticed that most commit messages were short, action-oriented, and specific. Examples included messages like "Validate Store operation invariants" and "Improve error message for invalid hook usage." These messages quickly communicate the purpose of the change without unnecessary detail, making the project's history easier to understand.

## Commit Message Reflection

### What makes a good commit message?

A good commit message is short, specific, and written using an action verb such as Add, Fix, Update, Remove, or Refactor. It should clearly describe what changed without unnecessary detail and make the purpose of the change easy to understand.

### How does a clear commit message help in team collaboration?

Clear commit messages help team members quickly understand the history of a project without reading every code change. They improve communication, simplify code reviews, make debugging easier, and help developers identify when and why changes were introduced.

### How can poor commit messages cause issues later?

Poor commit messages such as "fixed stuff" or "update" provide little information about what actually changed. This makes debugging, maintaining software, and understanding project history much more difficult because developers must inspect each commit individually.

### Commit History Observation

While exploring the React repository, I noticed that most commit messages were short, action-oriented, and specific. Examples included "Validate Store operation invariants" and "Improve error message for invalid hook usage." These messages clearly communicate the purpose of the change without unnecessary detail, making the project's history easier to understand.

## Debugging with Git Bisect

### What does `git bisect` do?

`git bisect` helps identify the commit that introduced a bug by using a binary search through Git history. The developer provides a known good commit and a known bad commit. Git then checks out commits between them, and the developer marks each tested commit as good or bad until Git finds the first bad commit.

### When would you use it in a real-world debugging situation?

I would use `git bisect` when a feature worked previously but is broken in the current version, especially when many commits were made between the working and broken versions. It is useful when the bug can be reproduced consistently and there is a known point in the project history where the feature still worked correctly.

### How does it compare to manually reviewing commits?

`git bisect` is usually faster than manually reviewing commits because it eliminates approximately half of the remaining commits after each test. Manual review may require checking many commits one by one, while `git bisect` narrows the search efficiently. However, the developer still needs a reliable way to test whether each selected commit is good or bad.

### Practical Exercise

I created several commits containing a working result, then deliberately introduced an incorrect result in a later commit. I marked commit `a262dba` as known good and the latest broken commit as bad.

Git checked out earlier commits for testing. I inspected `bisect-demo.txt` at each selected commit and marked it as good when the result was correct and bad when the incorrect result was present.

Using this process, Git identified commit `5e5e84a` (`Update calculation result`) as the first commit that introduced the bug. I then used `git bisect reset` to leave bisect mode and return to my feature branch.
