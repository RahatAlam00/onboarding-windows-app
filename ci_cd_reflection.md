# CI/CD Reflection

During this task, I learned how automated quality checks improve the software development workflow. Before this, I thought documentation checks only happened manually. Now I understand that tools can automatically verify Markdown formatting and spelling before code is committed or merged.

I learned how Husky runs Git hooks locally and how lint-staged improves performance by checking only the staged Markdown files instead of the entire repository. This makes commits much faster while still maintaining documentation quality.

I also learned how GitHub Actions provides the same checks in the CI pipeline. Even if someone bypasses local checks, GitHub automatically validates the documentation before changes are merged into the main branch. This helps keep the repository consistent for everyone on the team.

Overall, this task helped me understand how local quality checks and continuous integration work together to catch issues early, reduce manual review effort, and maintain high-quality documentation.
