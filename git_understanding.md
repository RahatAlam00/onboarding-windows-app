<!-- cspell:ignore oneline -->
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

### Commit Message Style Examples

#### Vague commit message

```text
fixed stuff
```

This message is too vague because it does not explain what was changed or why. A developer reading the project history would need to open the commit and inspect the files to understand its purpose.

#### Overly detailed commit message

```text
Updated git_understanding.md by adding a reflection explaining that excessively detailed commit messages reduce readability, make Git history harder to scan quickly, and should generally be avoided in favour of concise summaries.
```

This message contains useful information, but it is too long for a commit title. It makes the Git history difficult to scan and includes more detail than is necessary for a short summary.

#### Well-structured commit message

```text
Add reflection on meaningful commit messages
```

This message is concise, specific, and begins with an action verb. It clearly explains what was added without including unnecessary detail.

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

## Advanced Git Commands

### `git checkout main -- <file>`

#### What does it do?

This command restores a specific file from the `main` branch without affecting other files or switching branches. It replaces the selected file with the version from `main`.

#### When would I use it in a real project?

I would use this command if I accidentally modified one file and wanted to restore only that file while keeping my other work. It is also useful when I need to copy the latest version of a single file from `main` into my current branch without merging the entire branch.

---

### `git cherry-pick <commit>`

#### What does it do?

`git cherry-pick` copies the changes from a specific commit onto the current branch without merging the whole source branch.

#### When would I use it in a real project?

I would use this when another branch contains one useful bug fix or feature that I need immediately, but I do not want to merge the entire branch because it may contain unfinished work.

#### Practical exercise

I created two commits on a temporary branch and then cherry-picked only the first commit onto my feature branch. Git created a new commit with the same changes but a different commit hash, demonstrating that cherry-pick copies a specific commit rather than merging the whole branch.

---

### `git log`

#### What does it do?

`git log` displays the commit history of a repository. It can show detailed commit information or a condensed view using options such as `--oneline` and `--graph`.

#### When would I use it in a real project?

I would use `git log` to understand how a project has evolved, find commit hashes, investigate when changes were introduced, and review the history before reverting, cherry-picking, or debugging.

---

### `git blame <file>`

#### What does it do?

`git blame` shows which commit last modified each line of a file, along with the author and date.

#### When would I use it in a real project?

I would use it to investigate the history of a specific line of code, identify the commit that introduced a change, and understand why it was modified before making further changes.

#### Practical exercise

I used `git blame` on `cherry-pick-demo.txt`, which showed that the line was last modified by commit `14bb808`. I then used `git show` to inspect that commit and see exactly what changes it introduced.

---

## Practical Evidence

### File restoration

I modified `git_understanding.md` and restored it using:

```bash
git checkout main -- git_understanding.md
```

### Cherry-pick

Source commit:

```text
2ffa3f7 Add first cherry-pick demo
```

Cherry-picked commit:

```text
14bb808 Add first cherry-pick demo
```

This demonstrated that Git created a new commit with a different hash while copying only the selected changes.

### Git blame

Running `git blame cherry-pick-demo.txt` showed that the line was last modified by commit `14bb808`, which I then inspected using `git show`.

## Reflection

### What surprised me while testing these commands?

I was surprised that `git cherry-pick` creates a completely new commit with a different commit hash even though the code changes are the same. I also found it useful that `git blame` identifies the exact commit responsible for each line, making it much easier to trace the history of a file. Another interesting discovery was that `git checkout main -- <file>` restores only the selected file without affecting the rest of the working directory, which is much safer than restoring the entire project.

## Branching and Team Collaboration

### Why is pushing directly to `main` problematic?

Pushing directly to `main` is risky because mistakes immediately affect the shared codebase. Bugs, unfinished features, or accidental changes can break the project for everyone. It also removes the opportunity for teammates to review the changes before they become part of the main branch.

### How do branches help with reviewing code?

Branches allow developers to work independently without affecting the stable version of the project. When the work is complete, a Pull Request can be opened so teammates can review the code, suggest improvements, and approve the changes before it is merged into `main`.

### What happens if two people edit the same file on different branches?

Git keeps the changes separate while each person works. When the branches are merged, Git automatically combines changes if they are in different parts of the file. If both people changed the same lines, Git reports a merge conflict that must be resolved before the merge can be completed.

## Staging vs. Committing

### What is the difference between staging and committing?

Staging selects which changes will be included in the next commit. The changes remain editable and are not yet part of Git's permanent history. Committing records the staged changes as a new snapshot in the repository history with a commit message, author, and timestamp.

### Why does Git separate these two steps?

Git separates staging and committing so developers can carefully choose which changes belong together. This allows related changes to be grouped into meaningful commits instead of committing every modified file at once.

### When would you want to stage changes without committing?

I would stage changes when I have finished part of my work but want to review it before creating a commit. It is also useful when multiple files have been modified but only some of them belong to the current feature or bug fix.
