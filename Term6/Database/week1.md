# Week 1 - Sept 14, 2026

https://vcsa.fast.sheridanc.on.ca/

ssh hadoopuser@10.31.153.107 -p 2221 (not working as of right now)
Sher1dan
export JAVA_HOME=`/usr/libexec/java_home -v 1.8`

### What is big data?
Data that is too large or complex for analysis in tradational relational databases

#### Defined by the three "Vs"
- Volume - Huge amounts of data
  - eg. Web Server logs, Click stream
- Variety - Structured, unstructured, semi-structered
  - eg. transactions, social media, email
- Velocity - new data generated frequently
  - eg. Sensor and Internet of Things processing
- Veracity - the quality of data
- Value - the business benefit of data

### Data Variety
- Structured Data
  - Data that has a well defined structure (eg. tuples, a row in a table)
  - It is easy to build a model for this data
    - Example: A table in a relational database; insert data into this model
    - Specific Example: a student record is a row in a table of all students
    - All records have the same attributes
- Unstructured Data
  - Data that cannot be fit easily into a certain structure
  - Example: email is an example of unstructured data
- Semi-Structured
  - Falls between the two. JSON and XML are an example

### Internet Impact on Data Management
- Objects generate and share new data
  - Sensors on devices can "call home"
  - IoT
- People, consume, generate and share data:
  - Text, image, audio, video
- Result: Data proliferation
  - Sharing information, knowledge, experiences, opinions, sentiment
  - New questions can be answered based on that data (eg. google)
  - Log files on everything, waiting to be analyzed

### Big Data Operations
- Data Acquisition
- Data ingestion
- Data Storage
- Data Processing
  - Cleaning
  - Transforming
  - Integrating
  - Analytics
  - Machine Learning
- Data Visualization

### RDBMS Analysis: A panacea
- Optimized, seperate database optimized for querying
  - RDBMS
    - Data Warehouse - enterprise
    - Data mart - Single subject
  - Denormalized star schema
    - Redundancy permitted
    - Efficient reads
    - Questions defined beforehand
    - Non-pertinent data discarded
  - Batch updates: Extract, Transform, Load
    - Extract - draw from source transactional DB
    - Transform - clean up, decode, expand
    - Load - Insert into star schema tables
    - Written in SQL or specialized tools

### Modern Data Sources
- Online Transaction Processing (OLTP)
  - Online Banking, Point-of-Sale (POS) terminals
  - ATM
  - Enterprise Resource Planning (ERP)
- Line-of-Business (LOB), application specific
- Customer Relationship Management (CRM)
- Event logs (e.g. Internet of Things/IoT)

### Traditional RDBMS Analysis Limits?
- How to handle unstructured and semi-structured data?
  - Only structured data (unless you have very sophisticated ETL)
  - Inefficient to store unstructured data in an RDBMS
- Source data schema changes usually break ETL processes
- Non-pertinent data was discarded
- Adding data can mean a re-write

### Data Lake Characteristics
- Data stored in raw format
  - Text, CSV, BLOB...
- Schema on Read
  - No pre-defined schema
  - Your code reads, interprets, transforms
    - Java, Python, Scala, Ruby, or via API etc.
- No data deleted before storing
- Scalable file system
- Beware: “Data swamp”
  - Deteriorated, unmanaged
  
### The Medallion Architecture
- Data is stored in the data lake on three different level
- Bronze Level
  - Raw data without modification
  - Can be structured, semi structured or unstructured
  - Large
- Silver Level
  - Cleaned data
  - Mostly structured
  - Integrated
  - Ready for analysis
- Golden level
  - Aggregated
  - Ready for reporting

### Data Structure Terms
- Schema-on-write
  - Requires well-defined structure
  - Writing to the database must adhere to this schema
- Schema-on-read
  - Writing has no specific structure
  - You can create your own structure from the unstructured or loosely structured data when you read the data

### CAP Theorem for Distributed Computing (Brewer’s Theorem)
- Consistency: All replicas of data are up-to-date
- Availability: You can always read, write and update data
- Partition Tolerance: Messages between nodes drop or delay