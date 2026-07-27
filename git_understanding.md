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
