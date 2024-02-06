### User

## Admin

- get /v1/users (get all users)
- get /v1/users/{userId} (get user by id)
- post /v1/users (create user)
- put /v1/users/{userId} (update user)
- delete /v1/users/{userId} (delete user)
- post /v1/users/{userId}/reset-password (reset user password)

## Logged in

- get /v1/user (get current logged user)
- get /v1/user/time-entries (get all time entries from user)
- post /v1/workspaces/{workspaceId}/time-entries (create time entry)
- get /v1/user/workspaces (get all workspaces from user)
- get /v1/user/workspaces/{workspaceId} (get workspace by id)
- post /v1/user/image (upload image)
- patch /v1/user (update user)
- put /v1/user/password (update password)
- put /v1/user/email (update email)
- get /v1/user/tasks (get all tasks from user)
- post /v1/user/receipts (create receipt)
- get /v1/user/receipts (get all receipts from user)

### Workspace

## Admin

- get /v1/workspaces (get all workspaces)
- get /v1/workspaces/{workspaceId} (get workspace by id)
- post /v1/workspaces (create workspace)
- post /v1/workspaces/{workspaceId}/users/{userId} (add user to workspace)
- delete /v1/workspaces/{workspaceId}/users/{userId} (remove user from workspace)

## Client / Admin

- get /v1/workspaces/{workspaceId}/users (get all users from workspace)
- post /v1/workspaces/{workspaceId}/users/info (get all users from workspace with info, filter by name, email, role, etc)
- post /v1/workspaces/{workspaceId}/users/{userId}/roles (add user to workspace as admin)
- delete /v1/workspaces/{workspaceId}/users/{userId}/roles (remove user from workspace as admin)

### TimeEntry

## Admin

## Admin / Client / ClientAdmin

- post /v1/workspaces/{workspaceId}/users/{userId}/time-entries (create time entry for user)
- get /v1/workspaces/{workspaceId}/time-entries (get all time entries from workspace)
- put /v1/workspaces/{workspaceId}/time-entries/{timeEntryId} (update time entry)
- delete /v1/workspaces/{workspaceId}/time-entries/{timeEntryId} (delete time entry)
- get /v1/workspaces/{workspaceId}/time-entries/{timeEntryId} (get time entry by id)
- patch /v1/workspaces/{workspaceId}/invoiced (mark time entries as invoiced)
- delete /v1/workspaces/{workspaceId}/users/{userId}/time-entries (delete all time entries from user)
- patch /v1/workspaces/{workspaceId}/user/{userId}/time-entries (Stop currently running time entry from user)

### Task

## Admin / Client / ClientAdmin

- get /v1/workspaces/{workspaceId}/tasks (get all tasks from workspace)
- post /v1/workspaces/{workspaceId}/tasks (create task)
- get /v1/workspaces/{workspaceId}/tasks/{taskId} (get task by id)
- put /v1/workspaces/{workspaceId}/tasks/{taskId} (update task)
- delete /v1/workspaces/{workspaceId}/tasks/{taskId} (delete task)
- patch /v1/workspaces/{workspaceId}/tasks/{taskId}/status (change task status)

### Receipt

## Admin

- get /v1/receipts (get all receipts)
- post /v1/receipts (create receipt)
- get /v1/receipts/{receiptId} (get receipt by id)
- put /v1/receipts/{receiptId} (update receipt)
- delete /v1/receipts/{receiptId} (delete receipt)
