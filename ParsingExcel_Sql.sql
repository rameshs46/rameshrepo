Create Table [dbo].[Employee](
ID Int Identity(1,1) NOT NULL,
Name varchar(50) NULL,
City varchar(50) NULL,
Address varchar(50) NULL,
Designation varchar(50) NULL,
Constraint [PK_Employee] Primary Key Clustered
(
  ID ASC
)with (PAD_Index = off, Statistics_NoReCompute = off, Ignore_DUP_Key = off, Allow_Row_Locks = ON, Allow_Page_Locks = ON) ON [Primary]
) ON [Primary]