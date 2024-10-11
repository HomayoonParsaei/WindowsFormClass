# UUID (Universally Unique Identifier)

A **UUID** (Universally Unique Identifier) is a 128-bit number used to uniquely identify objects or entities across different systems. It's similar to GUID (Globally Unique Identifier), and the two terms are often used interchangeably. UUIDs are most commonly represented as 32 hexadecimal characters, separated by hyphens, in the format `8-4-4-4-12`.

## Format of a UUID

A UUID is usually represented in this form:

xxxxxxxx-xxxx-Mxxx-Nxxx-xxxxxxxxxxxx


Where:
- `x` represents a hexadecimal digit (0-9, a-f).
- `M` indicates the version of the UUID.
- `N` indicates the variant of the UUID, which defines certain layout rules.

## UUID Versions

There are five standard versions of the UUID algorithm, each generating the UUID using different methods.

### 1. **Version 1 (Time-based)**
- Generated using the current timestamp and the machine's MAC address.
- Ensures uniqueness by combining the time and the machine's unique identifier (MAC address).
- Vulnerable to privacy issues because the MAC address can be traced.

### 2. **Version 2 (DCE Security)**
- Similar to Version 1, but incorporates a "POSIX UID/GID" for additional security.
- Not commonly used.

### 3. **Version 3 (Namespace-based, MD5)**
- Generated using an MD5 hash of a namespace (another identifier) and a name (a string).
- Guarantees that the same name in the same namespace always produces the same UUID.

 
