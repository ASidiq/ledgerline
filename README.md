# Ledgerline

Ledgerline is a multi-tenant payments ledger API. The API exposes a set of endpoints that enables clients to transfer funds between customer accounts, retrieve account statements, and view live balances. The API is also highly secure and ensures only authorised clients can the endpoints.

Planned core features:
1. Tenants and accounts – each tenant (a fintech client) owns customer accounts.
2. Transfers – POST /transfers moves money between accounts using double-entry ledger lines.
3. Statements – paged transaction history per account, with a read-optimised query.
4. Events – TransferCompleted published to a broker; a consumer sends webhooks.
5. Background jobs – nightly statement generation.
6. Real-time – live balance updates via SignalR.
7. SDK – a typed .NET client package for tenants.

# Testing 
Execute the command `dotnet test` at the root of the repo and all tests will run. 