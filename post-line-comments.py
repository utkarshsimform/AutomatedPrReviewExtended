import os
import json
import requests

GITHUB_TOKEN = os.environ.get('GITHUB_TOKEN')
GITHUB_REPOSITORY = os.environ.get('GITHUB_REPOSITORY')
GITHUB_PR_NUMBER = os.environ.get('PR_NUMBER')
GITHUB_SHA = os.environ.get('GITHUB_SHA')

# Example feedback structure: list of dicts with file, line, and message
# Replace this with your actual analysis output
feedback = [
    {
        "path": "AutomatedPRReviewExtended/Demo2.cs",
        "line": 10,
        "body": "Example: Consider using PascalCase for method names.",
        "side": "RIGHT"
    }
]

api_url = f"https://api.github.com/repos/{GITHUB_REPOSITORY}/pulls/{GITHUB_PR_NUMBER}/comments"
headers = {
    "Authorization": f"Bearer {GITHUB_TOKEN}",
    "Accept": "application/vnd.github+json"
}

for comment in feedback:
    data = {
        "body": comment["body"],
        "commit_id": GITHUB_SHA,
        "path": comment["path"],
        "side": comment["side"],
        "line": comment["line"]
    }
    response = requests.post(api_url, headers=headers, data=json.dumps(data))
    print(f"Comment on {comment['path']}:{comment['line']} - Status: {response.status_code}")
    if response.status_code >= 300:
        print(response.text)
