# CI/CD Reflection

## What is the purpose of CI/CD?

CI/CD (Continuous Integration and Continuous Delivery/Deployment) helps developers automatically build, test, and validate code whenever changes are made. It detects problems early, reduces manual work, and ensures software is always in a releasable state.

## How does automating style checks improve project quality?

Automated style checks ensure that documentation and code follow consistent formatting and spelling rules. This improves readability, reduces human error, and allows developers to focus on implementing features instead of manually reviewing formatting issues.

## What are some challenges with enforcing checks in CI/CD?

One challenge is that strict checks can temporarily slow development if developers need to fix formatting or linting errors before merging. CI pipelines also require maintenance, and incorrectly configured checks can produce unnecessary failures or increase build times.

## How do CI/CD pipelines differ between small projects and large teams?

Small projects usually have simple pipelines that run basic linting and tests. Large teams often use more advanced pipelines with multiple stages such as unit tests, integration tests, security scanning, deployment, and approval steps before code is merged.

## Personal Reflection

During this task, I learned how automated quality checks improve the software development workflow. Before this, I thought documentation checks only happened manually. Now I understand that tools can automatically verify Markdown formatting and spelling before code is committed or merged.

I learned how Husky runs Git hooks locally and how `lint-staged` improves performance by checking only the staged Markdown files instead of the entire repository. This makes commits much faster while still maintaining documentation quality.

I also learned how GitHub Actions provides the same checks in the CI pipeline. Even if someone bypasses local checks, GitHub automatically validates the documentation before changes are merged into the main branch. This helps keep the repository consistent for everyone on the team.

Overall, this task helped me understand how local quality checks and continuous integration work together to catch issues early, reduce manual review effort, and maintain high-quality documentation.

This pull request was used to test the automated CI checks.
